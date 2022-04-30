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
    public partial class ColorFilterParameters : Form
    {
        public ColorFilterParameters()
        {
            InitializeComponent();

            this.btnSetColorFilterParams.DialogResult = DialogResult.OK;
            this.btnCancel.DialogResult = DialogResult.Cancel;
        }

        public int RValue
        {
            get { return Convert.ToInt32(numRValue.Value); }
            set { numRValue.Value = value; }
        }

        public int GValue
        {
            get { return Convert.ToInt32(numGValue.Value); }
            set { numGValue.Value = value; }
        }

        public int BValue
        {
            get { return Convert.ToInt32(numBValue.Value); }
            set { numBValue.Value = value; }
        }

        private void btnSetColorFilterParams_Click(object sender, EventArgs e)
        {

        }

        private void ColorFilterParameters_Load(object sender, EventArgs e)
        {
            numRValue.Focus();
        }
    }
}
