using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp_File_Info
{
    public partial class UserControlFileInfo : UserControl
    {
        public UserControlFileInfo()
        {
            InitializeComponent();
        }

        private void getFileInfoButton_Click(object sender, EventArgs e)
        {
            MainWindow myParent = (MainWindow)this.Parent.Parent;
            bool isOk = false;
            if (myParent.fileName != "None")
            {
                isOk = true;

            }
            else
            {
                MessageBox.Show("Please select file");
            }
            if (isOk)
            {


                resetEverything();
                string file = myParent.fileName;
                FileInfo fileInfo = new FileInfo(file);
                try
                {
                    pictureBox1.Image = Icon.ExtractAssociatedIcon(file).ToBitmap();
                }
                catch 
                {
                  
                }
                FileNameLabel.Text = "Name: " + Path.GetFileNameWithoutExtension(file);
                FileExtensionLabel.Text = "Extension: " + Path.GetExtension(file);
                FilePathLabel.Text = "Path: " + file;
                FileReadOnlyLabel.Text = "Is Read Only: " + fileInfo.IsReadOnly;
                if (fileInfo.Attributes == FileAttributes.Hidden)
                {
                    FileIsHiddenLabel.Text = "Is Hidden: True";
                }
                else
                {
                    FileIsHiddenLabel.Text = "Is Hidden: False";
                }
                if (fileInfo.Length < 1024)
                {
                    //Bytes
                    FileSizeLabel.Text = "Logical Size: " + fileInfo.Length + " bytes";
                    FilePhysicalSizeLabel.Text = "Physical Size: " + GetFileSizeOnDisk(file) + " bytes";
                }
                else if (fileInfo.Length > 1024 && fileInfo.Length <= 1048576)
                {
                    //Kibibytes
                    double Kibibytes = fileInfo.Length / 1024f;
                    double PKibibytes = GetFileSizeOnDisk(file) / 1024f;
                    FileSizeLabel.Text = "Logical Size: " + Math.Round(Kibibytes, 3) + " KiB (" + fileInfo.Length + " bytes)";
                    FilePhysicalSizeLabel.Text = "Physical Size: " + Math.Round(PKibibytes, 3) + " KiB (" + GetFileSizeOnDisk(file) + " bytes)";
                }
                else if (fileInfo.Length > 1048576 && fileInfo.Length <= 1073741824)
                {
                    //Mebibytes
                    double Mebibytes = (fileInfo.Length / 1024f) / 1024f;
                    double PMebibytes = (GetFileSizeOnDisk(file) / 1024f) / 1024f;
                    FileSizeLabel.Text = "Logical Size: " + Math.Round(Mebibytes, 3) + " MiB (" + fileInfo.Length + " bytes)";
                    FilePhysicalSizeLabel.Text = "Physical Size: " + Math.Round(PMebibytes, 3) + " MiB (" + GetFileSizeOnDisk(file) + " bytes)";
                }
                else if (fileInfo.Length > 1073741824 && fileInfo.Length <= 1099511627776)
                {
                    //Gibibytes
                    double Gibibytes = ((fileInfo.Length / 1024f) / 1024f) / 1024f;
                    double PGibibytes = ((GetFileSizeOnDisk(file) / 1024f) / 1024f) / 1024f;
                    FileSizeLabel.Text = "Logical Size: " + Math.Round(Gibibytes, 3) + " GiB (" + fileInfo.Length + " bytes)";
                    FilePhysicalSizeLabel.Text = "Physical Size: " + Math.Round(PGibibytes, 3) + " GiB (" + GetFileSizeOnDisk(file) + " bytes)";
                }
                else if (fileInfo.Length > 1099511627776)
                {
                    //Tebibytes
                    double Tebibytes = (((fileInfo.Length / 1024f) / 1024f) / 1024f) / 1024f;
                    double PTebibytes = (((GetFileSizeOnDisk(file) / 1024f) / 1024f) / 1024f) / 1024f;
                    FileSizeLabel.Text = "Logical Size: " + Math.Round(Tebibytes, 3) + " TiB (" + fileInfo.Length + " bytes)";
                    FilePhysicalSizeLabel.Text = "Physical Size: " + Math.Round(PTebibytes, 3) + " TiB (" + GetFileSizeOnDisk(file) + " bytes)";
                }
                FileCreatedLabel.Text = "Created: " + File.GetCreationTimeUtc(file).DayOfWeek + " " + File.GetCreationTimeUtc(file);
                FileModifiedLabel.Text = "Modified: " + File.GetLastWriteTimeUtc(file).DayOfWeek + " " + File.GetLastWriteTimeUtc(file);
                FileLastAccessLabel.Text = "Last Access: " + File.GetLastAccessTimeUtc(file).DayOfWeek + " " + File.GetLastAccessTimeUtc(file);

                FileSecurity fileSec = fileInfo.GetAccessControl();
                var authRuleColl =
                       fileSec.GetAccessRules(true, true, typeof(NTAccount));
                float n = 100F;
                int m = 60;
                int i = 0;
                string labelnameI;
                string labelnameA;
                string labelnameF;
                var labelDictionary = new Dictionary<string, Label>();
                foreach (FileSystemAccessRule fsaRule in authRuleColl)
                {
                    i++;
                    SecurityTable.RowCount++;
                    SecurityTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                    SecurityTable.Size = new Size(SecurityTable.Size.Width, m);

                    labelnameI = "IdentityReferenceLabel" + i;
                    labelnameA = "AccessControlTypeLabel" + i;
                    labelnameF = "FileSystemRightsLabel" + i;


                    labelDictionary[labelnameI] = new Label();
                    labelDictionary[labelnameA] = new Label();
                    labelDictionary[labelnameF] = new Label();

                    labelDictionary[labelnameI].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                    labelDictionary[labelnameI].AutoSize = true;
                    labelDictionary[labelnameI].Location = new System.Drawing.Point(3, 8);
                    labelDictionary[labelnameI].Name = "IdentityReferenceLabel";
                    labelDictionary[labelnameI].Size = new System.Drawing.Size(320, 13);
                    labelDictionary[labelnameI].TabIndex = 0;
                    labelDictionary[labelnameI].Text = "Identity Reference";
                    // 
                    // AccessControlTypeLabel
                    // 
                    labelDictionary[labelnameA].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                    labelDictionary[labelnameA].AutoSize = true;
                    labelDictionary[labelnameA].Location = new System.Drawing.Point(329, 8);
                    labelDictionary[labelnameA].Name = "AccessControlTypeLabel";
                    labelDictionary[labelnameA].Size = new System.Drawing.Size(157, 13);
                    labelDictionary[labelnameA].TabIndex = 1;
                    labelDictionary[labelnameA].Text = "Access Control Reference";
                    // 
                    // FileSystemRightsLabel
                    // 
                    labelDictionary[labelnameF].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                    labelDictionary[labelnameF].AutoSize = true;
                    labelDictionary[labelnameF].Location = new System.Drawing.Point(492, 8);
                    labelDictionary[labelnameF].Name = "FileSystemRightsLabel";
                    labelDictionary[labelnameF].Size = new System.Drawing.Size(322, 13);
                    labelDictionary[labelnameF].TabIndex = 2;
                    labelDictionary[labelnameF].Text = "File System Rights";

                    SecurityTable.Controls.Add(labelDictionary[labelnameA], 1, SecurityTable.RowCount - 1);
                    SecurityTable.Controls.Add(labelDictionary[labelnameI], 0, SecurityTable.RowCount - 1);
                    SecurityTable.Controls.Add(labelDictionary[labelnameF], 2, SecurityTable.RowCount - 1);


                    labelDictionary[labelnameI].Text = fsaRule.IdentityReference.ToString();
                    labelDictionary[labelnameA].Text = fsaRule.AccessControlType.ToString();
                    labelDictionary[labelnameF].Text = fsaRule.FileSystemRights.ToString();




                    n += 50F;
                    m += 30;
                }
            }
        }

        

        public static long GetFileSizeOnDisk(string file)
        {
            FileInfo info = new FileInfo(file);
            uint dummy, sectorsPerCluster, bytesPerSector;
            int result = GetDiskFreeSpaceW(info.Directory.Root.FullName, out sectorsPerCluster, out bytesPerSector, out dummy, out dummy);
            if (result == 0) throw new Win32Exception();
            uint clusterSize = sectorsPerCluster * bytesPerSector;
            uint hosize;
            uint losize = GetCompressedFileSizeW(file, out hosize);
            long size;
            size = (long)hosize << 32 | losize;
            return ((size + clusterSize - 1) / clusterSize) * clusterSize;
        }



        [DllImport("kernel32.dll")]
        static extern uint GetCompressedFileSizeW([In, MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
        [Out, MarshalAs(UnmanagedType.U4)] out uint lpFileSizeHigh);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        static extern int GetDiskFreeSpaceW([In, MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName,
           out uint lpSectorsPerCluster, out uint lpBytesPerSector, out uint lpNumberOfFreeClusters,
           out uint lpTotalNumberOfClusters);

        void resetEverything()
        {
            Size size = Size;
            pictureBox1.Dispose();
            FileIsHiddenLabel.Dispose();
            FileReadOnlyLabel.Dispose();
            FileInformationsLabel.Dispose();
            getFileInfoButton.Dispose();
            FileNameLabel.Dispose();
            FileExtensionLabel.Dispose();
            FilePathLabel.Dispose();
            FileSizeLabel.Dispose();
            FilePhysicalSizeLabel.Dispose();
            FileCreatedLabel.Dispose();
            FileModifiedLabel.Dispose();
            FileLastAccessLabel.Dispose();
            SecurityTable.Dispose();
            AccessControlTypeLabel.Dispose();
            IdentityReferenceLabel.Dispose();
            FileSystemRightsLabel.Dispose();
            SecurityLabel.Dispose();
            ClearLabelsButton.Dispose();
            SearchOnlineButton.Dispose();

            InitializeComponent();
            Size = size;
            
        }

        private void SearchOnlineButton_Click(object sender, EventArgs e)
        {
            MainWindow myParent = (MainWindow)this.Parent.Parent;
            bool isOk = false;
            if (myParent.fileName != "None")
            {
                isOk = true;

            }
            else
            {
                MessageBox.Show("Please select file");
            }
            if (isOk)
            {
                string file = myParent.fileName;
                string link = "https://duckduckgo.com/?q=" + Path.GetExtension(file) + "+extension";
                System.Diagnostics.Process.Start(link);
            }
            
        }

        private void ClearLabelsButton_Click(object sender, EventArgs e)
        {
            resetEverything();
        }
    }
}
