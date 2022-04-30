using ImageFilters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSProject
{
    public partial class frmImageFilters : Form
    {
        private const int stackSize = 5;
        Stack<Bitmap> undoStack;
        Stack<Bitmap> redoStack;
        private Bitmap m_Bitmap;

        public frmImageFilters()
        {
            InitializeComponent();

            m_Bitmap = new Bitmap(2, 2);
            undoStack = new Stack<Bitmap>(stackSize);
            redoStack = new Stack<Bitmap>(stackSize);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CombinedPath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Resources");
            openFileDialog.InitialDirectory = Path.GetFullPath(CombinedPath);
            openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|GIF files(*.gif)|*.gif|PNG files(*.png)|*.png|All valid files|*.bmp/*.jpg/*.gif/*.png";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                try
                {
                    m_Bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);
                    this.AutoScroll = true;
                    this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width), (int)(m_Bitmap.Height));
                    //pbImageDisplay.Image = (Image)m_Bitmap.Clone();;
                    pbImageDisplay.Image = (Image)m_Bitmap.Clone();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = @"../../../Resources";
            saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                try
                {
                    m_Bitmap.Save(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void frmImageFilters_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;

            //g.DrawImage(m_Bitmap, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y, m_Bitmap.Width, m_Bitmap.Height));
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            ColorFilterParameters colorFilterParametersForm = new ColorFilterParameters();
            colorFilterParametersForm.RValue = 0;
            colorFilterParametersForm.GValue = 0;
            colorFilterParametersForm.BValue = 0;

            if (colorFilterParametersForm.ShowDialog() == DialogResult.OK)
            {
                undoStack.Push((Bitmap)m_Bitmap.Clone());
                redoStack.Clear();

                Filters.ApplyColorFilter(m_Bitmap,
                                         colorFilterParametersForm.RValue,
                                         colorFilterParametersForm.GValue,
                                         colorFilterParametersForm.BValue);
                //pbImageDisplay.Image = (Image)m_Bitmap.Clone();;
                pbImageDisplay.Image = (Image)m_Bitmap.Clone();
            }
        }

        private void displayChanelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            Bitmap[] channelBmps = Filters.GetChannelsRGB(m_Bitmap);
            ChannelsDisplayForm channelsDisplayForm = new ChannelsDisplayForm(m_Bitmap, channelBmps[0], channelBmps[1], channelBmps[2]);
            channelsDisplayForm.ShowDialog();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoStack.Count == 0)
            {
                MessageBox.Show("Cannot undo. Make some changes to image first.");
                return;
            }

            redoStack.Push((Bitmap)m_Bitmap.Clone());

            m_Bitmap = (Bitmap)undoStack.Pop().Clone();
            pbImageDisplay.Image = (Image)m_Bitmap.Clone(); ;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redoStack.Count == 0)
            {
                MessageBox.Show("Cannot redo. Undo some changes to image first.");
                return;
            }

            undoStack.Push((Bitmap)m_Bitmap.Clone());

            m_Bitmap = (Bitmap)redoStack.Pop().Clone();
            pbImageDisplay.Image = (Image)m_Bitmap.Clone(); ;
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            undoStack.Push((Bitmap)m_Bitmap.Clone());
            redoStack.Clear();

            Filters.ApplyInvertFilter(m_Bitmap);
            pbImageDisplay.Image = (Image)m_Bitmap.Clone(); ;
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            undoStack.Push((Bitmap)m_Bitmap.Clone());
            redoStack.Clear();

            Filters.ApplyMeanRemovalFilter(m_Bitmap);
            pbImageDisplay.Image = (Image)m_Bitmap.Clone(); ;
        }

        private void edgeDetectHomogenityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            undoStack.Push((Bitmap)m_Bitmap.Clone());
            redoStack.Clear();

            Filters.ApplyEdgeDetectHomogenityFilter(m_Bitmap, 100, 100, 100);
            pbImageDisplay.Image = (Image)m_Bitmap.Clone(); ;
        }

        private void timeWarpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            undoStack.Push((Bitmap)m_Bitmap.Clone());
            redoStack.Clear();

            Filters.ApplyTimeWarpFilter(m_Bitmap, 15);
            pbImageDisplay.Image = (Image)m_Bitmap.Clone(); ;
        }

        private void showMethodOfExecutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplication designed with System.Drawing.Bitmap functionality, without win32 core functionality.");
        }

        private void showConvolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Convolution filters do not impact already filtered images.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tmpBmp = (Bitmap)m_Bitmap.Clone();
            Filters.ApplyCrossDomainColorizeFilter(tmpBmp, 300, 0.5);
            this.pbImageDisplay.Image = tmpBmp;

        }

        private void averageMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            undoStack.Push((Bitmap)m_Bitmap.Clone());
            redoStack.Clear();

            Filters.ApplyGrayscaleAvgFilter(m_Bitmap);
            pbImageDisplay.Image = (Image)m_Bitmap.Clone(); ;
        }

        private void maxMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            undoStack.Push((Bitmap)m_Bitmap.Clone());
            redoStack.Clear();

            Filters.ApplyGrayScaleMaxFilter(m_Bitmap);
            pbImageDisplay.Image = (Image)m_Bitmap.Clone(); ;
        }

        private void customMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            undoStack.Push((Bitmap)m_Bitmap.Clone());
            redoStack.Clear();

            Filters.ApplyGrayscaleCustomFilter(m_Bitmap);
            pbImageDisplay.Image = (Image)m_Bitmap.Clone(); ;
        }

        private void simpleColorizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            undoStack.Push((Bitmap)m_Bitmap.Clone());
            redoStack.Clear();

            Filters.ApplySimpleColorizeFilter(m_Bitmap);
            pbImageDisplay.Image = (Image)m_Bitmap.Clone();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //var bmp = (Bitmap)pbImageDisplay.Image;
            //var pixel = bmp.GetPixel(e.X, e.Y);
            //label1.Text = "R:" + pixel.R + ", G: " + pixel.G + ", B: " + pixel.B;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            var channelsData = Helpers.CollectHistogramDataFromBitmap(m_Bitmap);
            HistogramDisplayForm histogramForm = new HistogramDisplayForm(m_Bitmap, channelsData);
            histogramForm.ShowDialog();
        }

        private void showComparisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            var avgGrayscale = (Bitmap)m_Bitmap.Clone();
            Filters.ApplyGrayscaleAvgFilter(avgGrayscale);

            var maxGrayscale = (Bitmap)m_Bitmap.Clone();
            Filters.ApplyGrayScaleMaxFilter(maxGrayscale);

            var customGrayscale = (Bitmap)m_Bitmap.Clone();
            Filters.ApplyGrayscaleCustomFilter(customGrayscale);

            ChannelsDisplayForm channelsDisplayForm = new ChannelsDisplayForm(m_Bitmap, avgGrayscale, maxGrayscale, customGrayscale);
            channelsDisplayForm.ShowDialog();
        }

        private void crossdomainColorizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Bitmap == null)
            {
                MessageBox.Show("Please load an image. File->Load");
                return;
            }

            undoStack.Push((Bitmap)m_Bitmap.Clone());
            redoStack.Clear();

            Filters.ApplyCrossDomainColorizeFilter(m_Bitmap, 300, 0.5);
            pbImageDisplay.Image = (Image)m_Bitmap.Clone();
        }
    }
}
