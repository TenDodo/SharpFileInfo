
namespace Sharp_File_Info
{
    partial class UserControlHashes
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
            this.MD5Button = new System.Windows.Forms.Button();
            this.CRC32Button = new System.Windows.Forms.Button();
            this.SHA1Button = new System.Windows.Forms.Button();
            this.SHA256Button = new System.Windows.Forms.Button();
            this.SHA384Button = new System.Windows.Forms.Button();
            this.SHA512Button = new System.Windows.Forms.Button();
            this.MD5Label = new System.Windows.Forms.LinkLabel();
            this.CRC32Label = new System.Windows.Forms.LinkLabel();
            this.SHA1Label = new System.Windows.Forms.LinkLabel();
            this.SHA256Label = new System.Windows.Forms.LinkLabel();
            this.SHA384Label = new System.Windows.Forms.LinkLabel();
            this.SHA512Label = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.resetHashesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MD5Button
            // 
            this.MD5Button.Location = new System.Drawing.Point(3, 3);
            this.MD5Button.Name = "MD5Button";
            this.MD5Button.Size = new System.Drawing.Size(75, 23);
            this.MD5Button.TabIndex = 0;
            this.MD5Button.Text = "MD5";
            this.MD5Button.UseVisualStyleBackColor = true;
            this.MD5Button.Click += new System.EventHandler(this.MD5Button_Click);
            // 
            // CRC32Button
            // 
            this.CRC32Button.Location = new System.Drawing.Point(3, 63);
            this.CRC32Button.Name = "CRC32Button";
            this.CRC32Button.Size = new System.Drawing.Size(75, 23);
            this.CRC32Button.TabIndex = 1;
            this.CRC32Button.Text = "CRC32";
            this.CRC32Button.UseVisualStyleBackColor = true;
            this.CRC32Button.Click += new System.EventHandler(this.CRC32Button_Click);
            // 
            // SHA1Button
            // 
            this.SHA1Button.Location = new System.Drawing.Point(3, 123);
            this.SHA1Button.Name = "SHA1Button";
            this.SHA1Button.Size = new System.Drawing.Size(75, 23);
            this.SHA1Button.TabIndex = 2;
            this.SHA1Button.Text = "SHA1";
            this.SHA1Button.UseVisualStyleBackColor = true;
            this.SHA1Button.Click += new System.EventHandler(this.SHA1Button_Click);
            // 
            // SHA256Button
            // 
            this.SHA256Button.Location = new System.Drawing.Point(3, 183);
            this.SHA256Button.Name = "SHA256Button";
            this.SHA256Button.Size = new System.Drawing.Size(75, 23);
            this.SHA256Button.TabIndex = 3;
            this.SHA256Button.Text = "SHA256";
            this.SHA256Button.UseVisualStyleBackColor = true;
            this.SHA256Button.Click += new System.EventHandler(this.SHA256Button_Click);
            // 
            // SHA384Button
            // 
            this.SHA384Button.Location = new System.Drawing.Point(3, 243);
            this.SHA384Button.Name = "SHA384Button";
            this.SHA384Button.Size = new System.Drawing.Size(75, 23);
            this.SHA384Button.TabIndex = 4;
            this.SHA384Button.Text = "SHA384";
            this.SHA384Button.UseVisualStyleBackColor = true;
            this.SHA384Button.Click += new System.EventHandler(this.SHA384Button_Click);
            // 
            // SHA512Button
            // 
            this.SHA512Button.Location = new System.Drawing.Point(3, 303);
            this.SHA512Button.Name = "SHA512Button";
            this.SHA512Button.Size = new System.Drawing.Size(75, 23);
            this.SHA512Button.TabIndex = 5;
            this.SHA512Button.Text = "SHA512";
            this.SHA512Button.UseVisualStyleBackColor = true;
            this.SHA512Button.Click += new System.EventHandler(this.SHA512Button_Click);
            // 
            // MD5Label
            // 
            this.MD5Label.AutoSize = true;
            this.MD5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MD5Label.LinkColor = System.Drawing.Color.Black;
            this.MD5Label.Location = new System.Drawing.Point(3, 33);
            this.MD5Label.Name = "MD5Label";
            this.MD5Label.Size = new System.Drawing.Size(43, 20);
            this.MD5Label.TabIndex = 6;
            this.MD5Label.TabStop = true;
            this.MD5Label.Text = "MD5";
            this.MD5Label.Click += new System.EventHandler(this.MD5Label_Click);
            // 
            // CRC32Label
            // 
            this.CRC32Label.AutoSize = true;
            this.CRC32Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CRC32Label.LinkColor = System.Drawing.Color.Black;
            this.CRC32Label.Location = new System.Drawing.Point(3, 93);
            this.CRC32Label.Name = "CRC32Label";
            this.CRC32Label.Size = new System.Drawing.Size(61, 20);
            this.CRC32Label.TabIndex = 7;
            this.CRC32Label.TabStop = true;
            this.CRC32Label.Text = "CRC32";
            this.CRC32Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CRC32Label_LinkClicked);
            // 
            // SHA1Label
            // 
            this.SHA1Label.AutoSize = true;
            this.SHA1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SHA1Label.LinkColor = System.Drawing.Color.Black;
            this.SHA1Label.Location = new System.Drawing.Point(3, 153);
            this.SHA1Label.Name = "SHA1Label";
            this.SHA1Label.Size = new System.Drawing.Size(52, 20);
            this.SHA1Label.TabIndex = 8;
            this.SHA1Label.TabStop = true;
            this.SHA1Label.Text = "SHA1";
            this.SHA1Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SHA1Label_LinkClicked);
            // 
            // SHA256Label
            // 
            this.SHA256Label.AutoSize = true;
            this.SHA256Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SHA256Label.LinkColor = System.Drawing.Color.Black;
            this.SHA256Label.Location = new System.Drawing.Point(3, 213);
            this.SHA256Label.Name = "SHA256Label";
            this.SHA256Label.Size = new System.Drawing.Size(70, 20);
            this.SHA256Label.TabIndex = 9;
            this.SHA256Label.TabStop = true;
            this.SHA256Label.Text = "SHA256";
            this.SHA256Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SHA256Label_LinkClicked);
            // 
            // SHA384Label
            // 
            this.SHA384Label.AutoSize = true;
            this.SHA384Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SHA384Label.LinkColor = System.Drawing.Color.Black;
            this.SHA384Label.Location = new System.Drawing.Point(3, 273);
            this.SHA384Label.Name = "SHA384Label";
            this.SHA384Label.Size = new System.Drawing.Size(70, 20);
            this.SHA384Label.TabIndex = 10;
            this.SHA384Label.TabStop = true;
            this.SHA384Label.Text = "SHA384";
            this.SHA384Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SHA384Label_LinkClicked);
            // 
            // SHA512Label
            // 
            this.SHA512Label.AutoSize = true;
            this.SHA512Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SHA512Label.LinkColor = System.Drawing.Color.Black;
            this.SHA512Label.Location = new System.Drawing.Point(3, 333);
            this.SHA512Label.Name = "SHA512Label";
            this.SHA512Label.Size = new System.Drawing.Size(70, 20);
            this.SHA512Label.TabIndex = 11;
            this.SHA512Label.TabStop = true;
            this.SHA512Label.Text = "SHA512";
            this.SHA512Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SHA512Label_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Click checksum to copy it to clipboard";
            // 
            // resetHashesButton
            // 
            this.resetHashesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetHashesButton.Location = new System.Drawing.Point(280, 454);
            this.resetHashesButton.Name = "resetHashesButton";
            this.resetHashesButton.Size = new System.Drawing.Size(154, 20);
            this.resetHashesButton.TabIndex = 13;
            this.resetHashesButton.Text = "Clear Labels";
            this.resetHashesButton.UseVisualStyleBackColor = true;
            this.resetHashesButton.Click += new System.EventHandler(this.resetHashesButton_Click);
            // 
            // UserControlHashes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.resetHashesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SHA512Label);
            this.Controls.Add(this.SHA384Label);
            this.Controls.Add(this.SHA256Label);
            this.Controls.Add(this.SHA1Label);
            this.Controls.Add(this.CRC32Label);
            this.Controls.Add(this.MD5Label);
            this.Controls.Add(this.SHA512Button);
            this.Controls.Add(this.SHA384Button);
            this.Controls.Add(this.SHA256Button);
            this.Controls.Add(this.SHA1Button);
            this.Controls.Add(this.CRC32Button);
            this.Controls.Add(this.MD5Button);
            this.Name = "UserControlHashes";
            this.Size = new System.Drawing.Size(648, 486);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MD5Button;
        private System.Windows.Forms.Button CRC32Button;
        private System.Windows.Forms.Button SHA1Button;
        private System.Windows.Forms.Button SHA256Button;
        private System.Windows.Forms.Button SHA384Button;
        private System.Windows.Forms.Button SHA512Button;
        private System.Windows.Forms.LinkLabel MD5Label;
        private System.Windows.Forms.LinkLabel CRC32Label;
        private System.Windows.Forms.LinkLabel SHA1Label;
        private System.Windows.Forms.LinkLabel SHA256Label;
        private System.Windows.Forms.LinkLabel SHA384Label;
        private System.Windows.Forms.LinkLabel SHA512Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetHashesButton;
    }
}
