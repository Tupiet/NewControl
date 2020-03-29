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
using System.IO.Compression;

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
                initialFile.Multiselect = true;

                if (initialFile.ShowDialog() == DialogResult.OK)
                {
                    foreach (String file in initialFile.FileNames)
                    {
                        Console.WriteLine("Hola");
                    }
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
                    introductControlLabel.Visible = true;
                    copyButton.Visible = true;
                    compressButton.Visible = true;
                    extractButton.Visible = true;
                }
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            foreach (String file in initialFile.FileNames)
            {
                // Selects the file path (file) and the name and extension of the file (fileName)
                // from each selected file.
                string fileName = Path.GetFileName(file);
                File.Move(file, finalFile.SelectedPath + "/" + fileName);
            }
            MessageBox.Show("Mogut!");
            
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(finalFile.SelectedPath + "/hola");
            foreach (String file in initialFile.FileNames)
            {
                string fileName = Path.GetFileName(file);
                File.Move(file, finalFile.SelectedPath + "/hola/" + fileName);
            }

            ZipFile.CreateFromDirectory(finalFile.SelectedPath + "/hola", finalFile.SelectedPath + "/hola.zip");
            Directory.Delete(finalFile.SelectedPath + "/hola", true);
            MessageBox.Show("Comprimit!");
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            ZipFile.ExtractToDirectory(initialFile.FileName, finalFile.SelectedPath);
            File.Delete(initialFile.FileName);
            MessageBox.Show("Descomprimit!");
        }
    }
}