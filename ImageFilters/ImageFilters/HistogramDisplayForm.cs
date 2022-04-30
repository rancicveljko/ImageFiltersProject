using MMSProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilters
{
    public partial class HistogramDisplayForm : Form
    {
        private Bitmap m_SrcBmp;
        private HistogramData[] channelsData;

        public HistogramDisplayForm()
        {
            InitializeComponent();
        }
        public HistogramDisplayForm(Bitmap b, HistogramData[] channelsData)
        {
            InitializeComponent();

            this.channelsData = channelsData;
            m_SrcBmp = (Bitmap)b.Clone();
            FillCharts(this.channelsData);
        }

        private void FillCharts(HistogramData[] channelsData)
        {
            var xList = Enumerable.Range(0, channelsData[0].Frequencies.Count).ToList();

            this.chartR.Series["R Channel Values"].Points.DataBindXY(xList, channelsData[0].Frequencies);
            this.chartG.Series["G Channel Values"].Points.DataBindXY(xList, channelsData[1].Frequencies);
            this.chartB.Series["B Channel Values"].Points.DataBindXY(xList, channelsData[2].Frequencies);
        }

        private void HistogramDisplayForm_Paint(object sender, PaintEventArgs e)
        {
            this.pbSrcBmp.Image = m_SrcBmp;
        }

        private void cropHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CropHistogramParametersForm cropForm = new CropHistogramParametersForm();
            if (cropForm.ShowDialog() == DialogResult.OK)
            {
                Helpers.CropHistogramData(this.channelsData, cropForm.T, cropForm.C);
                FillCharts(this.channelsData);
            }
        }
    }
}
