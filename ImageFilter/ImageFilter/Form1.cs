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

namespace ImageFilter
{
    public partial class Form1 : Form
    {
        private Dictionary<int, int> dimensions;
        private String inputFolder = "";
        private String outputFolder = "";
        private Form2 dimensionDialog = new Form2();

        public Form1()
        {
            InitializeComponent();
            inputFolder = brwserInput.SelectedPath;
            outputFolder =brwserOutput.SelectedPath;
            txtInput.Text = inputFolder;
            txtOutput.Text = outputFolder;
            dimensions = new Dictionary<int, int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = brwserInput.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputFolder = brwserInput.SelectedPath;
                /*string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                foreach (string file in files)
                {
                    MessageBox.Show(file);
                }*/
            }
            txtInput.Text = inputFolder;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = brwserOutput.ShowDialog();
            if (result == DialogResult.OK)
            {
                outputFolder = brwserOutput.SelectedPath;
            }
            txtOutput.Text = outputFolder;
        }

        private void btnAddDmns_Click(object sender, EventArgs e)
        {
            if (dimensionDialog.ShowDialog(this) == DialogResult.OK 
                && (dimensionDialog.getXDimension() != 0 
                || dimensionDialog.getYDimension()!=0))
            {
                int x = dimensionDialog.getXDimension();
                int y = dimensionDialog.getYDimension();

                if (!dimensions.ContainsKey(x))
                {
                    lstDimensions.Items.Add(dimensionDialog.getXDimension() + "x" + dimensionDialog.getYDimension());
                    dimensions.Add(x, y);
                }
                else MessageBox.Show("Can't add two dimensions with the same X-value");

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(inputFolder);
            Image image;
            foreach (string file in files)
            {
                image = Image.FromFile(file);
                foreach (KeyValuePair<int, int> dimension in dimensions)
                {
                    if (image.Width == dimension.Key && image.Height == dimension.Value)
                    {
                        String fileName = file.Split('\\').Last();
                        try
                        {
                            File.Copy(file, outputFolder + "\\" + fileName);
                        }
                        catch (IOException )
                        {
                            
                        }
                    }
                    
                }
                image.Dispose();
                //MessageBox.Show(file);
                image = null;
                System.GC.Collect();
            }
            files = null;
            MessageBox.Show("All done");

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            inputFolder = txtInput.Text;
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            outputFolder = txtOutput.Text;
        }

        private void btnRemoveDmns_Click(object sender, EventArgs e)
        {
            if (dimensionDialog.ShowDialog(this) == DialogResult.OK)
            {
                lstDimensions.Items.Remove(dimensionDialog.getXDimension() + "x" + dimensionDialog.getYDimension());
                dimensions.Remove(dimensionDialog.getXDimension());
            }
        }
    }
}
