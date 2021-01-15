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
using System.Security.Cryptography;

namespace Sharp_File_Info
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select the file to open:";
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                fileName = openFile.FileName;
                Filename.Text = "File: " + fileName;
                
            }
            else
            {
                MessageBox.Show("Failed to open the file");
            }
        }
        public string fileName;
        private void MainWindow_Load(object sender, EventArgs e)
        {
            fileName = "None";
            Filename.Text = "Selected File: " + fileName;


        }
        void SelectedControl(UserControl selectedControl)
        {
            userControlHashes1.Hide();
            userControlEXIF1.Hide();
            userControlFileInfo1.Hide();

            selectedControl.Show();
            selectedControl.BringToFront();
        }
        private void HashesButton_Click(object sender, EventArgs e)
        {
            SelectedControl(userControlHashes1);
        }

        private void EXIFButton_Click(object sender, EventArgs e)
        {
            SelectedControl(userControlEXIF1);
        }

        private void FileInfoButton_Click(object sender, EventArgs e)
        {
            SelectedControl(userControlFileInfo1);
        }
    }
}
