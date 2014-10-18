using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilter
{
    public partial class Form2 : Form
    {
        private int xDimension;
        private int yDimension;

        public Form2()
        {
            InitializeComponent();
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            xDimension = Int32.Parse(nmrX.Text);
            yDimension = Int32.Parse(nmrY.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int getXDimension()
        {
            return xDimension;
        }

        public int getYDimension()
        {
            return yDimension;
        }

    }
}
