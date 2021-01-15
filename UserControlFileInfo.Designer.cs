
namespace Sharp_File_Info
{
    partial class UserControlFileInfo
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileInformationsLabel = new System.Windows.Forms.Label();
            this.getFileInfoButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileExtensionLabel = new System.Windows.Forms.Label();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.FileSizeLabel = new System.Windows.Forms.Label();
            this.FilePhysicalSizeLabel = new System.Windows.Forms.Label();
            this.FileCreatedLabel = new System.Windows.Forms.Label();
            this.FileModifiedLabel = new System.Windows.Forms.Label();
            this.FileLastAccessLabel = new System.Windows.Forms.Label();
            this.SecurityTable = new System.Windows.Forms.TableLayoutPanel();
            this.AccessControlTypeLabel = new System.Windows.Forms.Label();
            this.IdentityReferenceLabel = new System.Windows.Forms.Label();
            this.FileSystemRightsLabel = new System.Windows.Forms.Label();
            this.SecurityLabel = new System.Windows.Forms.Label();
            this.SearchOnlineButton = new System.Windows.Forms.Button();
            this.ClearLabelsButton = new System.Windows.Forms.Button();
            this.FileReadOnlyLabel = new System.Windows.Forms.Label();
            this.FileIsHiddenLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SecurityTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileInformationsLabel
            // 
            this.FileInformationsLabel.AutoSize = true;
            this.FileInformationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileInformationsLabel.Location = new System.Drawing.Point(3, 29);
            this.FileInformationsLabel.Name = "FileInformationsLabel";
            this.FileInformationsLabel.Size = new System.Drawing.Size(178, 25);
            this.FileInformationsLabel.TabIndex = 0;
            this.FileInformationsLabel.Text = "File Informations:";
            // 
            // getFileInfoButton
            // 
            this.getFileInfoButton.Location = new System.Drawing.Point(3, 3);
            this.getFileInfoButton.Name = "getFileInfoButton";
            this.getFileInfoButton.Size = new System.Drawing.Size(200, 23);
            this.getFileInfoButton.TabIndex = 1;
            this.getFileInfoButton.Text = "Get File Info";
            this.getFileInfoButton.UseVisualStyleBackColor = true;
            this.getFileInfoButton.Click += new System.EventHandler(this.getFileInfoButton_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileNameLabel.Location = new System.Drawing.Point(3, 62);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(59, 20);
            this.FileNameLabel.TabIndex = 2;
            this.FileNameLabel.Text = "Name: ";
            // 
            // FileExtensionLabel
            // 
            this.FileExtensionLabel.AutoSize = true;
            this.FileExtensionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileExtensionLabel.Location = new System.Drawing.Point(3, 92);
            this.FileExtensionLabel.Name = "FileExtensionLabel";
            this.FileExtensionLabel.Size = new System.Drawing.Size(87, 20);
            this.FileExtensionLabel.TabIndex = 3;
            this.FileExtensionLabel.Text = "Extension: ";
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilePathLabel.Location = new System.Drawing.Point(3, 122);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(50, 20);
            this.FilePathLabel.TabIndex = 4;
            this.FilePathLabel.Text = "Path: ";
            // 
            // FileSizeLabel
            // 
            this.FileSizeLabel.AutoSize = true;
            this.FileSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileSizeLabel.Location = new System.Drawing.Point(3, 152);
            this.FileSizeLabel.Name = "FileSizeLabel";
            this.FileSizeLabel.Size = new System.Drawing.Size(102, 20);
            this.FileSizeLabel.TabIndex = 5;
            this.FileSizeLabel.Text = "Logical Size: ";
            // 
            // FilePhysicalSizeLabel
            // 
            this.FilePhysicalSizeLabel.AutoSize = true;
            this.FilePhysicalSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilePhysicalSizeLabel.Location = new System.Drawing.Point(3, 182);
            this.FilePhysicalSizeLabel.Name = "FilePhysicalSizeLabel";
            this.FilePhysicalSizeLabel.Size = new System.Drawing.Size(109, 20);
            this.FilePhysicalSizeLabel.TabIndex = 6;
            this.FilePhysicalSizeLabel.Text = "Physical Size: ";
            // 
            // FileCreatedLabel
            // 
            this.FileCreatedLabel.AutoSize = true;
            this.FileCreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileCreatedLabel.Location = new System.Drawing.Point(3, 212);
            this.FileCreatedLabel.Name = "FileCreatedLabel";
            this.FileCreatedLabel.Size = new System.Drawing.Size(74, 20);
            this.FileCreatedLabel.TabIndex = 7;
            this.FileCreatedLabel.Text = "Created: ";
            // 
            // FileModifiedLabel
            // 
            this.FileModifiedLabel.AutoSize = true;
            this.FileModifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileModifiedLabel.Location = new System.Drawing.Point(3, 242);
            this.FileModifiedLabel.Name = "FileModifiedLabel";
            this.FileModifiedLabel.Size = new System.Drawing.Size(77, 20);
            this.FileModifiedLabel.TabIndex = 8;
            this.FileModifiedLabel.Text = "Modified: ";
            // 
            // FileLastAccessLabel
            // 
            this.FileLastAccessLabel.AutoSize = true;
            this.FileLastAccessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileLastAccessLabel.Location = new System.Drawing.Point(3, 272);
            this.FileLastAccessLabel.Name = "FileLastAccessLabel";
            this.FileLastAccessLabel.Size = new System.Drawing.Size(104, 20);
            this.FileLastAccessLabel.TabIndex = 9;
            this.FileLastAccessLabel.Text = "Last Access: ";
            // 
            // SecurityTable
            // 
            this.SecurityTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecurityTable.AutoScroll = true;
            this.SecurityTable.BackColor = System.Drawing.Color.DimGray;
            this.SecurityTable.ColumnCount = 3;
            this.SecurityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.SecurityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SecurityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.SecurityTable.Controls.Add(this.AccessControlTypeLabel, 1, 0);
            this.SecurityTable.Controls.Add(this.IdentityReferenceLabel, 0, 0);
            this.SecurityTable.Controls.Add(this.FileSystemRightsLabel, 2, 0);
            this.SecurityTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SecurityTable.Location = new System.Drawing.Point(3, 395);
            this.SecurityTable.Name = "SecurityTable";
            this.SecurityTable.RowCount = 1;
            this.SecurityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SecurityTable.Size = new System.Drawing.Size(747, 30);
            this.SecurityTable.TabIndex = 10;
            // 
            // AccessControlTypeLabel
            // 
            this.AccessControlTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AccessControlTypeLabel.AutoSize = true;
            this.AccessControlTypeLabel.Location = new System.Drawing.Point(301, 8);
            this.AccessControlTypeLabel.Name = "AccessControlTypeLabel";
            this.AccessControlTypeLabel.Size = new System.Drawing.Size(143, 13);
            this.AccessControlTypeLabel.TabIndex = 1;
            this.AccessControlTypeLabel.Text = "Access Control Reference";
            // 
            // IdentityReferenceLabel
            // 
            this.IdentityReferenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityReferenceLabel.AutoSize = true;
            this.IdentityReferenceLabel.Location = new System.Drawing.Point(3, 8);
            this.IdentityReferenceLabel.Name = "IdentityReferenceLabel";
            this.IdentityReferenceLabel.Size = new System.Drawing.Size(292, 13);
            this.IdentityReferenceLabel.TabIndex = 0;
            this.IdentityReferenceLabel.Text = "Identity Reference";
            // 
            // FileSystemRightsLabel
            // 
            this.FileSystemRightsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSystemRightsLabel.AutoSize = true;
            this.FileSystemRightsLabel.Location = new System.Drawing.Point(450, 8);
            this.FileSystemRightsLabel.Name = "FileSystemRightsLabel";
            this.FileSystemRightsLabel.Size = new System.Drawing.Size(294, 13);
            this.FileSystemRightsLabel.TabIndex = 2;
            this.FileSystemRightsLabel.Text = "File System Rights";
            // 
            // SecurityLabel
            // 
            this.SecurityLabel.AutoSize = true;
            this.SecurityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SecurityLabel.Location = new System.Drawing.Point(3, 362);
            this.SecurityLabel.Name = "SecurityLabel";
            this.SecurityLabel.Size = new System.Drawing.Size(104, 25);
            this.SecurityLabel.TabIndex = 11;
            this.SecurityLabel.Text = "Security: ";
            // 
            // SearchOnlineButton
            // 
            this.SearchOnlineButton.Location = new System.Drawing.Point(209, 3);
            this.SearchOnlineButton.Name = "SearchOnlineButton";
            this.SearchOnlineButton.Size = new System.Drawing.Size(200, 23);
            this.SearchOnlineButton.TabIndex = 12;
            this.SearchOnlineButton.Text = "Search for the extension online";
            this.SearchOnlineButton.UseVisualStyleBackColor = true;
            this.SearchOnlineButton.Click += new System.EventHandler(this.SearchOnlineButton_Click);
            // 
            // ClearLabelsButton
            // 
            this.ClearLabelsButton.Location = new System.Drawing.Point(415, 3);
            this.ClearLabelsButton.Name = "ClearLabelsButton";
            this.ClearLabelsButton.Size = new System.Drawing.Size(200, 23);
            this.ClearLabelsButton.TabIndex = 13;
            this.ClearLabelsButton.Text = "Clear Labels";
            this.ClearLabelsButton.UseVisualStyleBackColor = true;
            this.ClearLabelsButton.Click += new System.EventHandler(this.ClearLabelsButton_Click);
            // 
            // FileReadOnlyLabel
            // 
            this.FileReadOnlyLabel.AutoSize = true;
            this.FileReadOnlyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileReadOnlyLabel.Location = new System.Drawing.Point(3, 302);
            this.FileReadOnlyLabel.Name = "FileReadOnlyLabel";
            this.FileReadOnlyLabel.Size = new System.Drawing.Size(108, 20);
            this.FileReadOnlyLabel.TabIndex = 14;
            this.FileReadOnlyLabel.Text = "Is Read Only: ";
            // 
            // FileIsHiddenLabel
            // 
            this.FileIsHiddenLabel.AutoSize = true;
            this.FileIsHiddenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileIsHiddenLabel.Location = new System.Drawing.Point(3, 332);
            this.FileIsHiddenLabel.Name = "FileIsHiddenLabel";
            this.FileIsHiddenLabel.Size = new System.Drawing.Size(85, 20);
            this.FileIsHiddenLabel.TabIndex = 15;
            this.FileIsHiddenLabel.Text = "Is Hidden: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(704, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlFileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FileIsHiddenLabel);
            this.Controls.Add(this.FileReadOnlyLabel);
            this.Controls.Add(this.ClearLabelsButton);
            this.Controls.Add(this.SearchOnlineButton);
            this.Controls.Add(this.SecurityLabel);
            this.Controls.Add(this.SecurityTable);
            this.Controls.Add(this.FileLastAccessLabel);
            this.Controls.Add(this.FileModifiedLabel);
            this.Controls.Add(this.FileCreatedLabel);
            this.Controls.Add(this.FilePhysicalSizeLabel);
            this.Controls.Add(this.FileSizeLabel);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.FileExtensionLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.getFileInfoButton);
            this.Controls.Add(this.FileInformationsLabel);
            this.Name = "UserControlFileInfo";
            this.Size = new System.Drawing.Size(753, 560);
            this.SecurityTable.ResumeLayout(false);
            this.SecurityTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileInformationsLabel;
        private System.Windows.Forms.Button getFileInfoButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileExtensionLabel;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Label FileSizeLabel;
        private System.Windows.Forms.Label FilePhysicalSizeLabel;
        private System.Windows.Forms.Label FileCreatedLabel;
        private System.Windows.Forms.Label FileModifiedLabel;
        private System.Windows.Forms.Label FileLastAccessLabel;
        private System.Windows.Forms.TableLayoutPanel SecurityTable;
        private System.Windows.Forms.Label AccessControlTypeLabel;
        private System.Windows.Forms.Label IdentityReferenceLabel;
        private System.Windows.Forms.Label FileSystemRightsLabel;
        private System.Windows.Forms.Label SecurityLabel;
        private System.Windows.Forms.Button SearchOnlineButton;
        private System.Windows.Forms.Button ClearLabelsButton;
        private System.Windows.Forms.Label FileReadOnlyLabel;
        private System.Windows.Forms.Label FileIsHiddenLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
