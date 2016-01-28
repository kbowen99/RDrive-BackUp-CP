namespace BackUp
{
    partial class Frm_Backup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Backup));
            this.Txt_Source = new System.Windows.Forms.TextBox();
            this.lbl_Source = new System.Windows.Forms.Label();
            this.Lbl_Dest = new System.Windows.Forms.Label();
            this.Txt_Dest = new System.Windows.Forms.TextBox();
            this.Fbd_Source = new System.Windows.Forms.FolderBrowserDialog();
            this.Fbd_Dest = new System.Windows.Forms.FolderBrowserDialog();
            this.Btn_Dest = new System.Windows.Forms.Button();
            this.Btn_Source = new System.Windows.Forms.Button();
            this.Btn_Backup = new System.Windows.Forms.Button();
            this.Btn_Resume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Source
            // 
            this.Txt_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Source.Location = new System.Drawing.Point(106, 12);
            this.Txt_Source.Multiline = true;
            this.Txt_Source.Name = "Txt_Source";
            this.Txt_Source.Size = new System.Drawing.Size(413, 28);
            this.Txt_Source.TabIndex = 0;
            this.Txt_Source.Text = "R:\\";
            // 
            // lbl_Source
            // 
            this.lbl_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Source.Location = new System.Drawing.Point(12, 10);
            this.lbl_Source.Name = "lbl_Source";
            this.lbl_Source.Size = new System.Drawing.Size(75, 20);
            this.lbl_Source.TabIndex = 1;
            this.lbl_Source.Text = "Source";
            // 
            // Lbl_Dest
            // 
            this.Lbl_Dest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dest.Location = new System.Drawing.Point(12, 49);
            this.Lbl_Dest.Name = "Lbl_Dest";
            this.Lbl_Dest.Size = new System.Drawing.Size(100, 20);
            this.Lbl_Dest.TabIndex = 3;
            this.Lbl_Dest.Text = "Destination";
            // 
            // Txt_Dest
            // 
            this.Txt_Dest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Dest.Location = new System.Drawing.Point(106, 46);
            this.Txt_Dest.Multiline = true;
            this.Txt_Dest.Name = "Txt_Dest";
            this.Txt_Dest.Size = new System.Drawing.Size(413, 28);
            this.Txt_Dest.TabIndex = 4;
            // 
            // Fbd_Source
            // 
            this.Fbd_Source.SelectedPath = "R:\\";
            // 
            // Btn_Dest
            // 
            this.Btn_Dest.BackgroundImage = global::BackUp.Properties.Resources.Folder1;
            this.Btn_Dest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Dest.Location = new System.Drawing.Point(525, 46);
            this.Btn_Dest.Name = "Btn_Dest";
            this.Btn_Dest.Size = new System.Drawing.Size(75, 28);
            this.Btn_Dest.TabIndex = 5;
            this.Btn_Dest.Text = " ";
            this.Btn_Dest.UseVisualStyleBackColor = true;
            this.Btn_Dest.Click += new System.EventHandler(this.Btn_Dest_Click);
            // 
            // Btn_Source
            // 
            this.Btn_Source.BackgroundImage = global::BackUp.Properties.Resources.Folder1;
            this.Btn_Source.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Source.Location = new System.Drawing.Point(525, 12);
            this.Btn_Source.Name = "Btn_Source";
            this.Btn_Source.Size = new System.Drawing.Size(75, 28);
            this.Btn_Source.TabIndex = 2;
            this.Btn_Source.Text = " ";
            this.Btn_Source.UseVisualStyleBackColor = true;
            this.Btn_Source.Click += new System.EventHandler(this.Btn_Source_Click);
            // 
            // Btn_Backup
            // 
            this.Btn_Backup.Location = new System.Drawing.Point(12, 80);
            this.Btn_Backup.Name = "Btn_Backup";
            this.Btn_Backup.Size = new System.Drawing.Size(588, 49);
            this.Btn_Backup.TabIndex = 6;
            this.Btn_Backup.Text = "Backup";
            this.Btn_Backup.UseVisualStyleBackColor = true;
            this.Btn_Backup.Click += new System.EventHandler(this.Btn_Backup_Click);
            // 
            // Btn_Resume
            // 
            this.Btn_Resume.Location = new System.Drawing.Point(12, 135);
            this.Btn_Resume.Name = "Btn_Resume";
            this.Btn_Resume.Size = new System.Drawing.Size(588, 28);
            this.Btn_Resume.TabIndex = 7;
            this.Btn_Resume.Text = "Resume Copy";
            this.Btn_Resume.UseVisualStyleBackColor = true;
            this.Btn_Resume.Click += new System.EventHandler(this.Btn_Resume_Click);
            // 
            // Frm_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 175);
            this.Controls.Add(this.Btn_Resume);
            this.Controls.Add(this.Btn_Backup);
            this.Controls.Add(this.Btn_Dest);
            this.Controls.Add(this.Txt_Dest);
            this.Controls.Add(this.Lbl_Dest);
            this.Controls.Add(this.Btn_Source);
            this.Controls.Add(this.lbl_Source);
            this.Controls.Add(this.Txt_Source);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Backup";
            this.Text = "R Drive Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Source;
        private System.Windows.Forms.Label lbl_Source;
        private System.Windows.Forms.Button Btn_Source;
        private System.Windows.Forms.Label Lbl_Dest;
        private System.Windows.Forms.TextBox Txt_Dest;
        private System.Windows.Forms.Button Btn_Dest;
        private System.Windows.Forms.FolderBrowserDialog Fbd_Source;
        private System.Windows.Forms.FolderBrowserDialog Fbd_Dest;
        private System.Windows.Forms.Button Btn_Backup;
        private System.Windows.Forms.Button Btn_Resume;
    }
}

