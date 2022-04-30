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
    public partial class CropHistogramParametersForm : Form
    {
        public int T
        {
            get { return Convert.ToInt32(numT.Value); } 
            set { numT.Value = value; }
        }
        public int C
        {
            get { return Convert.ToInt32(numC.Value); }
            set { numC.Value = value; }
        }

        public CropHistogramParametersForm()
        {
            InitializeComponent();

            this.btnSetParams.DialogResult = DialogResult.OK;
            this.btnCancel.DialogResult = DialogResult.Cancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
