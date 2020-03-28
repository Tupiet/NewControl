using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Copy
{
    public partial class Form1 : Form
    {
        public OpenFileDialog initialFile = new OpenFileDialog();
        public FolderBrowserDialog finalFile = new FolderBrowserDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void initialFileButton_Click(object sender, EventArgs e)
        {
            using (initialFile)
            {
                if (initialFile.ShowDialog() == DialogResult.OK)
                {
                    // This is the initial path directory.
                    MessageBox.Show(initialFile.FileName);
                }
            }
        }

        private void finalFileButton_Click(object sender, EventArgs e)
        {
            using (finalFile)
            {
                if (finalFile.ShowDialog() == DialogResult.OK)
                {
                    // This is the final path directory.
                    MessageBox.Show(finalFile.SelectedPath);
                }
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            File.Move(initialFile.FileName, finalFile.SelectedPath + "/" + initialFile.SafeFileName);
            MessageBox.Show("Completat");
        }

    }
}
