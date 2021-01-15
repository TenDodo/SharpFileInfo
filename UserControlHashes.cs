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
    public partial class UserControlHashes : UserControl
    {
        public UserControlHashes()
        {
            InitializeComponent();
        }
        
        private void MD5Button_Click(object sender, EventArgs e)
        {
            MainWindow myParent = (MainWindow)this.Parent.Parent;
            if (myParent.fileName != "None")
            {
                MD5Label.Text = CalculateMD5(myParent.fileName);
            }
            else
            {
                MessageBox.Show("Please select file");
            }
            
        }

        static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void CRC32Button_Click(object sender, EventArgs e)
        {
            MainWindow myParent = (MainWindow)this.Parent.Parent;
            if (myParent.fileName != "None")
            {
                try
                {
                    CRC32Label.Text = CalculateCRC32(myParent.fileName);
                }
                catch (Exception)
                {

                    MessageBox.Show("The file is being used by another process, please try again.");
                }
                
            }
            else
            {
                MessageBox.Show("Please select file");
            }
            
        }

        static string CalculateCRC32(string filename)
        {
            var crc32 = new Crc32();
            var hash = String.Empty;

            using (var fs = File.Open(filename, FileMode.Open))
            {
                foreach (byte b in crc32.ComputeHash(fs))
                {
                    hash += b.ToString("x2").ToLower();
                }
            }
            return hash;
        }

        private void SHA1Button_Click(object sender, EventArgs e)
        {
            MainWindow myParent = (MainWindow)this.Parent.Parent;
            if (myParent.fileName != "None")
            {
                try
                {
                    SHA1Label.Text = CalculateSHA1(myParent.fileName);
                }
                catch
                {
                    MessageBox.Show("The file is being used by another process, please try again.");
                }
                
            }
            else
            {
                MessageBox.Show("Please select file");
            }
            
        }

        static string CalculateSHA1(string filename)
        {
            using (var sha1 = SHA1.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = sha1.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void SHA256Button_Click(object sender, EventArgs e)
        {
            MainWindow myParent = (MainWindow)this.Parent.Parent;
            if (myParent.fileName != "None")
            {
                try
                {
                    SHA256Label.Text = CalculateSHA256(myParent.fileName);
                }
                catch
                {
                    MessageBox.Show("The file is being used by another process, please try again.");
                }
                
            }
            else
            {
                MessageBox.Show("Please select file");
            }
            
        }

        static string CalculateSHA256(string filename)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void SHA384Button_Click(object sender, EventArgs e)
        {
            MainWindow myParent = (MainWindow)this.Parent.Parent;
            if (myParent.fileName != "None")
            {
                
                try
                {
                    SHA384Label.Text = CalculateSHA384(myParent.fileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("The file is being used by another process, please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select file");
            }
            
        }

        static string CalculateSHA384(string filename)
        {
            using (var sha384 = SHA384.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = sha384.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void SHA512Button_Click(object sender, EventArgs e)
        {
            MainWindow myParent = (MainWindow)this.Parent.Parent;
            if (myParent.fileName != "None")
            {
                try
                {
                    SHA512Label.Text = CalculateSHA512(myParent.fileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("The file is being used by another process, please try again.");
                }
                
            }
            else
            {
                MessageBox.Show("Please select file");
            }
            
        }

        static string CalculateSHA512(string filename)
        {
            using (var sha512 = SHA512.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = sha512.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void MD5Label_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MD5Label.Text);
        }

        private void CRC32Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(CRC32Label.Text);
        }

        private void SHA1Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(SHA1Label.Text);
        }

        private void SHA256Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(SHA256Label.Text);
        }

        private void SHA384Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(SHA384Label.Text);
        }

        private void SHA512Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(SHA512Label.Text);
        }

        private void resetHashesButton_Click(object sender, EventArgs e)
        {
            MD5Label.Text = "MD5";
            CRC32Label.Text = "CRC32";
            SHA1Label.Text = "SHA1";
            SHA256Label.Text = "SHA256";
            SHA384Label.Text = "SHA384";
            SHA512Label.Text = "SHA512";
                
        }
    }
}
