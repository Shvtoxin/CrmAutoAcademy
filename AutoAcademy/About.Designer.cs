namespace CrmAutoAcademy
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            labelProductName = new Label();
            labelVersion = new Label();
            labelCopyright = new Label();
            labelCompanyName = new Label();
            textBoxDescription = new TextBox();
            OkBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(12, 113);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(38, 15);
            labelProductName.TabIndex = 0;
            labelProductName.Text = "label1";
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(12, 141);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(38, 15);
            labelVersion.TabIndex = 1;
            labelVersion.Text = "label2";
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Location = new Point(12, 171);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(38, 15);
            labelCopyright.TabIndex = 2;
            labelCopyright.Text = "label3";
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Location = new Point(12, 202);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(38, 15);
            labelCompanyName.TabIndex = 3;
            labelCompanyName.Text = "label4";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 234);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(436, 127);
            textBoxDescription.TabIndex = 4;
            // 
            // OkBtn
            // 
            OkBtn.Location = new Point(184, 367);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(75, 23);
            OkBtn.TabIndex = 5;
            OkBtn.Text = "OK";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 402);
            Controls.Add(OkBtn);
            Controls.Add(textBoxDescription);
            Controls.Add(labelCompanyName);
            Controls.Add(labelCopyright);
            Controls.Add(labelVersion);
            Controls.Add(labelProductName);
            Controls.Add(pictureBox1);
            Name = "About";
            Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProductName;
        private Label labelVersion;
        private Label labelCopyright;
        private Label labelCompanyName;
        private TextBox textBoxDescription;
        private Button OkBtn;
        private PictureBox pictureBox1;
    }
}