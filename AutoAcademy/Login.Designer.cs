namespace AutoAcademy
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            RolCb = new ComboBox();
            LogTb = new TextBox();
            PassTb = new TextBox();
            LoginBtn = new Button();
            ClearTb = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 99);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(327, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-31, -77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 117);
            label1.Name = "label1";
            label1.Size = new Size(312, 28);
            label1.TabIndex = 1;
            label1.Text = "Срм система Авто-Академия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 196);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 2;
            label2.Text = "Логин:";
            // 
            // RolCb
            // 
            RolCb.FormattingEnabled = true;
            RolCb.Items.AddRange(new object[] { "Sis-admin", "Teacher", "Administrator" });
            RolCb.Location = new Point(78, 160);
            RolCb.Name = "RolCb";
            RolCb.Size = new Size(212, 26);
            RolCb.TabIndex = 4;
            RolCb.Text = "Роль";
            // 
            // LogTb
            // 
            LogTb.Location = new Point(78, 227);
            LogTb.Name = "LogTb";
            LogTb.Size = new Size(212, 26);
            LogTb.TabIndex = 5;
            // 
            // PassTb
            // 
            PassTb.Location = new Point(78, 296);
            PassTb.Name = "PassTb";
            PassTb.Size = new Size(212, 26);
            PassTb.TabIndex = 6;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(107, 356);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.RightToLeft = RightToLeft.No;
            LoginBtn.Size = new Size(147, 34);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Войти";
            LoginBtn.UseMnemonic = false;
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ClearTb
            // 
            ClearTb.AutoSize = true;
            ClearTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Underline, GraphicsUnit.Point);
            ClearTb.Location = new Point(126, 393);
            ClearTb.Name = "ClearTb";
            ClearTb.Size = new Size(104, 18);
            ClearTb.TabIndex = 8;
            ClearTb.Text = "Сбросить ввод";
            ClearTb.Click += ClearTb_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 265);
            label3.Name = "label3";
            label3.Size = new Size(83, 24);
            label3.TabIndex = 3;
            label3.Text = "Пароль:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(371, 473);
            Controls.Add(ClearTb);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Controls.Add(PassTb);
            Controls.Add(LogTb);
            Controls.Add(RolCb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Label label2;
        private ComboBox RolCb;
        private PictureBox pictureBox2;
        private TextBox LogTb;
        private TextBox PassTb;
        private Button LoginBtn;
        private Label ClearTb;
        private Label label3;
    }
}