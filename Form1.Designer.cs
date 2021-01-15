
namespace Sharp_File_Info
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.FileInfoButton = new System.Windows.Forms.Button();
            this.EXIFButton = new System.Windows.Forms.Button();
            this.HashesButton = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Filename = new System.Windows.Forms.Label();
            this.userControlFileInfo1 = new Sharp_File_Info.UserControlFileInfo();
            this.userControlEXIF1 = new Sharp_File_Info.UserControlEXIF();
            this.userControlHashes1 = new Sharp_File_Info.UserControlHashes();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.FileInfoButton);
            this.panel1.Controls.Add(this.EXIFButton);
            this.panel1.Controls.Add(this.HashesButton);
            this.panel1.Controls.Add(this.OpenFile);
            this.panel1.Controls.Add(this.InfoLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 560);
            this.panel1.TabIndex = 0;
            // 
            // FileInfoButton
            // 
            this.FileInfoButton.Location = new System.Drawing.Point(4, 33);
            this.FileInfoButton.Name = "FileInfoButton";
            this.FileInfoButton.Size = new System.Drawing.Size(160, 23);
            this.FileInfoButton.TabIndex = 4;
            this.FileInfoButton.Text = "File Info";
            this.FileInfoButton.UseVisualStyleBackColor = true;
            this.FileInfoButton.Click += new System.EventHandler(this.FileInfoButton_Click);
            // 
            // EXIFButton
            // 
            this.EXIFButton.Location = new System.Drawing.Point(3, 91);
            this.EXIFButton.Name = "EXIFButton";
            this.EXIFButton.Size = new System.Drawing.Size(160, 23);
            this.EXIFButton.TabIndex = 3;
            this.EXIFButton.Text = "EXIF";
            this.EXIFButton.UseVisualStyleBackColor = true;
            this.EXIFButton.Click += new System.EventHandler(this.EXIFButton_Click);
            // 
            // HashesButton
            // 
            this.HashesButton.Location = new System.Drawing.Point(3, 62);
            this.HashesButton.Name = "HashesButton";
            this.HashesButton.Size = new System.Drawing.Size(160, 23);
            this.HashesButton.TabIndex = 2;
            this.HashesButton.Text = "Hashes";
            this.HashesButton.UseVisualStyleBackColor = true;
            this.HashesButton.Click += new System.EventHandler(this.HashesButton_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(4, 4);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(160, 23);
            this.OpenFile.TabIndex = 1;
            this.OpenFile.Text = "Select File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(4, 4);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 13);
            this.InfoLabel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.userControlFileInfo1);
            this.panel2.Controls.Add(this.userControlEXIF1);
            this.panel2.Controls.Add(this.userControlHashes1);
            this.panel2.Location = new System.Drawing.Point(186, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 560);
            this.panel2.TabIndex = 1;
            // 
            // Filename
            // 
            this.Filename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Filename.AutoSize = true;
            this.Filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Filename.Location = new System.Drawing.Point(12, 575);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(147, 20);
            this.Filename.TabIndex = 1;
            this.Filename.Text = "Selected File: None";
            // 
            // userControlFileInfo1
            // 
            this.userControlFileInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlFileInfo1.Location = new System.Drawing.Point(3, 3);
            this.userControlFileInfo1.Name = "userControlFileInfo1";
            this.userControlFileInfo1.Size = new System.Drawing.Size(747, 554);
            this.userControlFileInfo1.TabIndex = 2;
            this.userControlFileInfo1.Visible = false;
            // 
            // userControlEXIF1
            // 
            this.userControlEXIF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlEXIF1.AutoScroll = true;
            this.userControlEXIF1.Location = new System.Drawing.Point(3, 4);
            this.userControlEXIF1.Name = "userControlEXIF1";
            this.userControlEXIF1.Size = new System.Drawing.Size(747, 553);
            this.userControlEXIF1.TabIndex = 1;
            this.userControlEXIF1.Visible = false;
            // 
            // userControlHashes1
            // 
            this.userControlHashes1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlHashes1.AutoScroll = true;
            this.userControlHashes1.Location = new System.Drawing.Point(3, 4);
            this.userControlHashes1.Name = "userControlHashes1";
            this.userControlHashes1.Size = new System.Drawing.Size(747, 553);
            this.userControlHashes1.TabIndex = 0;
            this.userControlHashes1.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 604);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Sharp File Info";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Filename;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button HashesButton;
        private UserControlHashes userControlHashes1;
        private System.Windows.Forms.Button EXIFButton;
        private UserControlEXIF userControlEXIF1;
        private System.Windows.Forms.Button FileInfoButton;
        private UserControlFileInfo userControlFileInfo1;
    }
}

