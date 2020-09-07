using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace ImageConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.openFileDialog1.Multiselect = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.openFileDialog1.Multiselect = true;
            foreach (String file in openFileDialog1.FileNames)
            {
                MessageBox.Show(file);
                SaveBmpAsPNG(file);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void SaveBmpAsPNG(String file)
        {
            Image img1=Image.FromFile(file);
            img1.Save(Path.GetDirectoryName(file) + "/" + Path.GetFileNameWithoutExtension(file) + ".png", ImageFormat.Png);
        }
    }
}
