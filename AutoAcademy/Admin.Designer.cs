namespace CrmAutoAcademy
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel = new Panel();
            RPhoneTB = new MaskedTextBox();
            AdminsDGV = new DataGridView();
            RPassTb = new TextBox();
            label14 = new Label();
            pictureBox2 = new PictureBox();
            Editbtn = new Button();
            Delbtn = new Button();
            Addbtn = new Button();
            label9 = new Label();
            RNameTb = new TextBox();
            label7 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            HomeTb = new Label();
            AboutTb = new Label();
            pictureBox13 = new PictureBox();
            pictureBox7 = new PictureBox();
            label10 = new Label();
            AdminTb = new Label();
            pictureBox6 = new PictureBox();
            StudTb = new Label();
            pictureBox5 = new PictureBox();
            TeachTb = new Label();
            pictureBox4 = new PictureBox();
            logoutTb = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox8 = new PictureBox();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.Controls.Add(RPhoneTB);
            panel.Controls.Add(AdminsDGV);
            panel.Controls.Add(RPassTb);
            panel.Controls.Add(label14);
            panel.Controls.Add(pictureBox2);
            panel.Controls.Add(Editbtn);
            panel.Controls.Add(Delbtn);
            panel.Controls.Add(Addbtn);
            panel.Controls.Add(label9);
            panel.Controls.Add(RNameTb);
            panel.Controls.Add(label7);
            panel.Controls.Add(label1);
            panel.Controls.Add(panel2);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(1089, 646);
            panel.TabIndex = 2;
            // 
            // RPhoneTB
            // 
            RPhoneTB.Location = new Point(492, 101);
            RPhoneTB.Mask = "+7000-000-00-00";
            RPhoneTB.Name = "RPhoneTB";
            RPhoneTB.Size = new Size(212, 23);
            RPhoneTB.TabIndex = 53;
            // 
            // AdminsDGV
            // 
            AdminsDGV.AllowUserToAddRows = false;
            AdminsDGV.AllowUserToDeleteRows = false;
            AdminsDGV.BackgroundColor = Color.White;
            AdminsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminsDGV.GridColor = Color.Gray;
            AdminsDGV.Location = new Point(456, 142);
            AdminsDGV.MultiSelect = false;
            AdminsDGV.Name = "AdminsDGV";
            AdminsDGV.RowTemplate.Height = 25;
            AdminsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AdminsDGV.Size = new Size(608, 484);
            AdminsDGV.TabIndex = 50;
            AdminsDGV.CellContentClick += AdminsDGV_CellContentClick;
            // 
            // RPassTb
            // 
            RPassTb.Location = new Point(795, 101);
            RPassTb.Name = "RPassTb";
            RPassTb.Size = new Size(212, 23);
            RPassTb.TabIndex = 47;
            RPassTb.Text = "Введите пароль";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(795, 70);
            label14.Name = "label14";
            label14.Size = new Size(85, 24);
            label14.TabIndex = 46;
            label14.Text = "Пароль*";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1045, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Editbtn
            // 
            Editbtn.Location = new Point(238, 287);
            Editbtn.Name = "Editbtn";
            Editbtn.RightToLeft = RightToLeft.No;
            Editbtn.Size = new Size(147, 34);
            Editbtn.TabIndex = 38;
            Editbtn.Text = "Редактировать";
            Editbtn.UseMnemonic = false;
            Editbtn.UseVisualStyleBackColor = true;
            Editbtn.Click += Editbtn_Click;
            // 
            // Delbtn
            // 
            Delbtn.Location = new Point(238, 183);
            Delbtn.Name = "Delbtn";
            Delbtn.RightToLeft = RightToLeft.No;
            Delbtn.Size = new Size(147, 34);
            Delbtn.TabIndex = 37;
            Delbtn.Text = "Удалить";
            Delbtn.UseMnemonic = false;
            Delbtn.UseVisualStyleBackColor = true;
            Delbtn.Click += Delbtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(238, 233);
            Addbtn.Name = "Addbtn";
            Addbtn.RightToLeft = RightToLeft.No;
            Addbtn.Size = new Size(147, 34);
            Addbtn.TabIndex = 36;
            Addbtn.Text = "Добавить";
            Addbtn.UseMnemonic = false;
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(520, 70);
            label9.Name = "label9";
            label9.Size = new Size(99, 24);
            label9.TabIndex = 34;
            label9.Text = "Телефон*";
            // 
            // RNameTb
            // 
            RNameTb.Location = new Point(238, 101);
            RNameTb.Name = "RNameTb";
            RNameTb.Size = new Size(198, 23);
            RNameTb.TabIndex = 29;
            RNameTb.Text = "Введите ваще имя";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(238, 70);
            label7.Name = "label7";
            label7.Size = new Size(55, 24);
            label7.TabIndex = 28;
            label7.Text = "Имя*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(481, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 28);
            label1.TabIndex = 25;
            label1.Text = "Срм система Авто-Академия";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 646);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(HomeTb);
            panel3.Controls.Add(AboutTb);
            panel3.Controls.Add(pictureBox13);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(AdminTb);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(StudTb);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(TeachTb);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(logoutTb);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 646);
            panel3.TabIndex = 2;
            // 
            // HomeTb
            // 
            HomeTb.AutoSize = true;
            HomeTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            HomeTb.Location = new Point(76, 125);
            HomeTb.Name = "HomeTb";
            HomeTb.Size = new Size(83, 24);
            HomeTb.TabIndex = 28;
            HomeTb.Text = "Главная";
            HomeTb.Click += HomeTb_Click;
            // 
            // AboutTb
            // 
            AboutTb.AutoSize = true;
            AboutTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AboutTb.Location = new Point(76, 488);
            AboutTb.Name = "AboutTb";
            AboutTb.Size = new Size(85, 24);
            AboutTb.TabIndex = 26;
            AboutTb.Text = "Справка";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(12, 478);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(44, 43);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 25;
            pictureBox13.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 115);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(44, 48);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 27;
            pictureBox7.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(44, 88);
            label10.Name = "label10";
            label10.Size = new Size(95, 24);
            label10.TabIndex = 24;
            label10.Text = "Разделы:";
            // 
            // AdminTb
            // 
            AdminTb.AutoSize = true;
            AdminTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AdminTb.ForeColor = SystemColors.ControlText;
            AdminTb.Location = new Point(76, 368);
            AdminTb.Name = "AdminTb";
            AdminTb.Size = new Size(93, 24);
            AdminTb.TabIndex = 19;
            AdminTb.Text = "Админам";
            AdminTb.Click += AdminTb_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 346);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(67, 64);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // StudTb
            // 
            StudTb.AutoSize = true;
            StudTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            StudTb.ForeColor = Color.Black;
            StudTb.Location = new Point(72, 283);
            StudTb.Name = "StudTb";
            StudTb.Size = new Size(109, 24);
            StudTb.TabIndex = 17;
            StudTb.Text = "Студентам";
            StudTb.Click += StudTb_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 261);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 64);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // TeachTb
            // 
            TeachTb.AutoSize = true;
            TeachTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TeachTb.ForeColor = Color.Black;
            TeachTb.Location = new Point(76, 198);
            TeachTb.Name = "TeachTb";
            TeachTb.Size = new Size(97, 24);
            TeachTb.TabIndex = 15;
            TeachTb.Text = "Учителям";
            TeachTb.Click += TeachTb_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 177);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // logoutTb
            // 
            logoutTb.AutoSize = true;
            logoutTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            logoutTb.Location = new Point(44, 602);
            logoutTb.Name = "logoutTb";
            logoutTb.Size = new Size(68, 24);
            logoutTb.TabIndex = 13;
            logoutTb.Text = "Выход";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 594);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-122, -51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(85, 429);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 45;
            label2.Text = "Услуги";
            label2.Click += UslugTb_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 416);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(44, 52);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 44;
            pictureBox8.TabStop = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 646);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            Text = "Admin";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private TextBox RPassTb;
        private Label label14;
        private PictureBox pictureBox2;
        private Button Editbtn;
        private Button Delbtn;
        private Button Addbtn;
        private Label label9;
        private TextBox RNameTb;
        private Label label7;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label10;
        private Label AdminTb;
        private PictureBox pictureBox6;
        private Label StudTb;
        private PictureBox pictureBox5;
        private Label TeachTb;
        private PictureBox pictureBox4;
        private Label logoutTb;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private DataGridView AdminsDGV;
        private MaskedTextBox RPhoneTB;
        private Label AboutTb;
        private PictureBox pictureBox13;
        private Label HomeTb;
        private PictureBox pictureBox7;
        private Label label2;
        private PictureBox pictureBox8;
    }
}