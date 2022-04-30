using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSProject
{
    public partial class ChannelsDisplayForm : Form
    {
        private Bitmap m_SrcBitmap;
        private Bitmap bmpEdit1;
        private Bitmap bmpEdit2;
        private Bitmap bmpEdit3;
        public ChannelsDisplayForm()
        {
            InitializeComponent();

            m_SrcBitmap = new Bitmap(2, 2);
            bmpEdit1 = new Bitmap(2, 2); ;
            bmpEdit2 = new Bitmap(2, 2);
            bmpEdit3 = new Bitmap(2, 2);
        }

        public ChannelsDisplayForm(Bitmap srcBmp, Bitmap bEdit1, Bitmap bEdit2, Bitmap bEdit3)
        {
            InitializeComponent();

            m_SrcBitmap = (Bitmap)srcBmp.Clone();
            bmpEdit1 = (Bitmap)bEdit1.Clone();
            bmpEdit2 = (Bitmap)bEdit2.Clone();
            bmpEdit3 = (Bitmap)bEdit3.Clone();
        }

        private void ChannelsDisplayForm_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;

            //g.DrawImage(m_SrcBitmap, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y, m_SrcBitmap.Width, m_SrcBitmap.Height));
            //g.DrawImage(bmpEdit1, new Rectangle(this.AutoScrollPosition.X + m_SrcBitmap.Width, this.AutoScrollPosition.Y, bmpEdit1.Width, bmpEdit1.Height));
            //g.DrawImage(bmpEdit2, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y + m_SrcBitmap.Height, bmpEdit2.Width, bmpEdit2.Height));
            //g.DrawImage(bmpEdit3, new Rectangle(this.AutoScrollPosition.X + m_SrcBitmap.Width, this.AutoScrollPosition.Y + m_SrcBitmap.Height, bmpEdit3.Width, bmpEdit3.Height));

            pbSrcBmp.Image = m_SrcBitmap;


            pbEdit1Bmp.Location = new Point(pbSrcBmp.Location.X + pbSrcBmp.Width, pbSrcBmp.Location.Y);
            pbEdit1Bmp.Image = bmpEdit1;

            pbEdit2Bmp.Location = new Point(pbSrcBmp.Location.X, pbSrcBmp.Location.Y + pbSrcBmp.Height);
            pbEdit2Bmp.Image = bmpEdit2;

            pbEdit3Bmp.Location = new Point(pbSrcBmp.Location.X + pbSrcBmp.Width, pbSrcBmp.Location.Y + pbSrcBmp.Height);
            pbEdit3Bmp.Image = bmpEdit3;
        }
    }
}
