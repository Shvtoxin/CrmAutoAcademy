namespace CrmAutoAcademy
{
    partial class Abonement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abonement));
            panel1 = new Panel();
            label6 = new Label();
            NameUs = new TextBox();
            button1 = new Button();
            UslugaId = new ComboBox();
            UsCost = new TextBox();
            label4 = new Label();
            AbonDGV = new DataGridView();
            label5 = new Label();
            AvtoCb = new ComboBox();
            VidCb = new ComboBox();
            TeachIdCb = new ComboBox();
            StudIdCb = new ComboBox();
            NameTeach = new TextBox();
            label3 = new Label();
            AbonSumTxt = new RichTextBox();
            pictureBox2 = new PictureBox();
            AddBtn = new Button();
            NameStud = new TextBox();
            label7 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox8 = new PictureBox();
            HomeTb = new Label();
            pictureBox1 = new PictureBox();
            AboutTb = new Label();
            pictureBox6 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox7 = new PictureBox();
            logoutTb = new Label();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            AdminTb = new Label();
            TeachTb = new Label();
            pictureBox5 = new PictureBox();
            StudTb = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AbonDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(NameUs);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(UslugaId);
            panel1.Controls.Add(UsCost);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(AbonDGV);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(AvtoCb);
            panel1.Controls.Add(VidCb);
            panel1.Controls.Add(TeachIdCb);
            panel1.Controls.Add(StudIdCb);
            panel1.Controls.Add(NameTeach);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(AbonSumTxt);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(NameStud);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 646);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(414, 159);
            label6.Name = "label6";
            label6.Size = new Size(118, 18);
            label6.TabIndex = 65;
            label6.Text = "Название услуги";
            // 
            // NameUs
            // 
            NameUs.Location = new Point(414, 180);
            NameUs.Name = "NameUs";
            NameUs.Size = new Size(164, 23);
            NameUs.TabIndex = 64;
            // 
            // button1
            // 
            button1.Location = new Point(745, 298);
            button1.Name = "button1";
            button1.Size = new Size(145, 42);
            button1.TabIndex = 63;
            button1.Text = "Распечатать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UslugaId
            // 
            UslugaId.FormattingEnabled = true;
            UslugaId.Items.AddRange(new object[] { "А", "В", "ВЕ", "С", "СЕ", "Д" });
            UslugaId.Location = new Point(233, 178);
            UslugaId.Name = "UslugaId";
            UslugaId.Size = new Size(129, 23);
            UslugaId.TabIndex = 62;
            UslugaId.Text = "Usluga id";
            UslugaId.SelectionChangeCommitted += UslugaId_SelectionChangeCommitted;
            // 
            // UsCost
            // 
            UsCost.Location = new Point(233, 232);
            UsCost.Name = "UsCost";
            UsCost.Size = new Size(129, 23);
            UsCost.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(232, 211);
            label4.Name = "label4";
            label4.Size = new Size(78, 18);
            label4.TabIndex = 60;
            label4.Text = "Стоимость";
            // 
            // AbonDGV
            // 
            AbonDGV.AllowUserToAddRows = false;
            AbonDGV.AllowUserToDeleteRows = false;
            AbonDGV.BackgroundColor = Color.White;
            AbonDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AbonDGV.GridColor = Color.Gray;
            AbonDGV.Location = new Point(233, 353);
            AbonDGV.MultiSelect = false;
            AbonDGV.Name = "AbonDGV";
            AbonDGV.RowTemplate.Height = 25;
            AbonDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AbonDGV.Size = new Size(794, 264);
            AbonDGV.TabIndex = 59;
            AbonDGV.CellContentClick += AbonDGV_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(745, 46);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 58;
            label5.Text = "Абонемент";
            // 
            // AvtoCb
            // 
            AvtoCb.FormattingEnabled = true;
            AvtoCb.Items.AddRange(new object[] { "Lada 2107 ", "Lada 2110 ", "Lada Granta Cross", "Lada Kalina", "Lada Largus", "Lada Priora", "Patriot", "HYUNDAI Solaris", "AUDI SQ2" });
            AvtoCb.Location = new Point(414, 271);
            AvtoCb.Name = "AvtoCb";
            AvtoCb.Size = new Size(164, 23);
            AvtoCb.TabIndex = 57;
            AvtoCb.Text = " авто";
            // 
            // VidCb
            // 
            VidCb.FormattingEnabled = true;
            VidCb.Items.AddRange(new object[] { "", "Онлайн", "Очно" });
            VidCb.Location = new Point(414, 232);
            VidCb.Name = "VidCb";
            VidCb.Size = new Size(164, 23);
            VidCb.TabIndex = 56;
            VidCb.Text = "Вид обучения";
            // 
            // TeachIdCb
            // 
            TeachIdCb.FormattingEnabled = true;
            TeachIdCb.Items.AddRange(new object[] { "А", "В", "ВЕ", "С", "СЕ", "Д" });
            TeachIdCb.Location = new Point(234, 133);
            TeachIdCb.Name = "TeachIdCb";
            TeachIdCb.Size = new Size(128, 23);
            TeachIdCb.TabIndex = 54;
            TeachIdCb.Text = "Teach id";
            TeachIdCb.SelectionChangeCommitted += TeachIdCb_SelectionChangeCommitted;
            // 
            // StudIdCb
            // 
            StudIdCb.FormattingEnabled = true;
            StudIdCb.Items.AddRange(new object[] { "А", "В", "ВЕ", "С", "СЕ", "Д" });
            StudIdCb.Location = new Point(234, 86);
            StudIdCb.Name = "StudIdCb";
            StudIdCb.Size = new Size(128, 23);
            StudIdCb.TabIndex = 53;
            StudIdCb.Text = "Stud id";
            StudIdCb.SelectionChangeCommitted += StudIdCb_SelectionChangeCommitted;
            // 
            // NameTeach
            // 
            NameTeach.Location = new Point(414, 133);
            NameTeach.Name = "NameTeach";
            NameTeach.Size = new Size(164, 23);
            NameTeach.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(414, 112);
            label3.Name = "label3";
            label3.Size = new Size(93, 18);
            label3.TabIndex = 49;
            label3.Text = "Имя учителя";
            // 
            // AbonSumTxt
            // 
            AbonSumTxt.Location = new Point(593, 81);
            AbonSumTxt.Name = "AbonSumTxt";
            AbonSumTxt.Size = new Size(424, 211);
            AbonSumTxt.TabIndex = 42;
            AbonSumTxt.Text = "";
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
            // AddBtn
            // 
            AddBtn.Location = new Point(231, 298);
            AddBtn.Name = "AddBtn";
            AddBtn.RightToLeft = RightToLeft.No;
            AddBtn.Size = new Size(131, 34);
            AddBtn.TabIndex = 36;
            AddBtn.Text = "Добавить";
            AddBtn.UseMnemonic = false;
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // NameStud
            // 
            NameStud.Location = new Point(414, 86);
            NameStud.Name = "NameStud";
            NameStud.Size = new Size(164, 23);
            NameStud.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(414, 65);
            label7.Name = "label7";
            label7.Size = new Size(99, 18);
            label7.TabIndex = 28;
            label7.Text = "Имя студента";
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
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox13);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(logoutTb);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(AdminTb);
            panel3.Controls.Add(TeachTb);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(StudTb);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 646);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 399);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 43;
            label2.Text = "Услуги";
            label2.Click += UslugTb_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 386);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(44, 52);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 42;
            pictureBox8.TabStop = false;
            // 
            // HomeTb
            // 
            HomeTb.AutoSize = true;
            HomeTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            HomeTb.Location = new Point(76, 129);
            HomeTb.Name = "HomeTb";
            HomeTb.Size = new Size(83, 24);
            HomeTb.TabIndex = 41;
            HomeTb.Text = "Главная";
            HomeTb.Click += HomeTb_Click;
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
            // AboutTb
            // 
            AboutTb.AutoSize = true;
            AboutTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AboutTb.Location = new Point(76, 451);
            AboutTb.Name = "AboutTb";
            AboutTb.Size = new Size(85, 24);
            AboutTb.TabIndex = 39;
            AboutTb.Text = "Справка";
            AboutTb.Click += AboutTb_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 325);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(67, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(3, 451);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(44, 47);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 38;
            pictureBox13.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 597);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, 118);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(44, 45);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 40;
            pictureBox7.TabStop = false;
            // 
            // logoutTb
            // 
            logoutTb.AutoSize = true;
            logoutTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            logoutTb.Location = new Point(53, 605);
            logoutTb.Name = "logoutTb";
            logoutTb.Size = new Size(68, 24);
            logoutTb.TabIndex = 30;
            logoutTb.Text = "Выход";
            logoutTb.Click += logoutTb_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(53, 91);
            label10.Name = "label10";
            label10.Size = new Size(95, 24);
            label10.TabIndex = 37;
            label10.Text = "Разделы:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 180);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // AdminTb
            // 
            AdminTb.AutoSize = true;
            AdminTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AdminTb.ForeColor = SystemColors.ControlText;
            AdminTb.Location = new Point(76, 336);
            AdminTb.Name = "AdminTb";
            AdminTb.Size = new Size(83, 24);
            AdminTb.TabIndex = 36;
            AdminTb.Text = "Админы";
            AdminTb.Click += AdminTb_Click;
            // 
            // TeachTb
            // 
            TeachTb.AutoSize = true;
            TeachTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TeachTb.ForeColor = Color.Black;
            TeachTb.Location = new Point(76, 201);
            TeachTb.Name = "TeachTb";
            TeachTb.Size = new Size(84, 24);
            TeachTb.TabIndex = 32;
            TeachTb.Text = "Учителя";
            TeachTb.Click += TeachTb_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 251);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 59);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            // 
            // StudTb
            // 
            StudTb.AutoSize = true;
            StudTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            StudTb.ForeColor = Color.Black;
            StudTb.Location = new Point(76, 266);
            StudTb.Name = "StudTb";
            StudTb.Size = new Size(99, 24);
            StudTb.TabIndex = 34;
            StudTb.Text = "Студенты";
            StudTb.Click += StudTb_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Abonement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 646);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Abonement";
            Text = "Abonement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AbonDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private RichTextBox AbonSumTxt;
        private PictureBox pictureBox2;
        private Button AddBtn;
        private TextBox NameStud;
        private Label label7;
        private Label label1;
        private Panel panel2;
        private TextBox NameTeach;
        private Label label3;
        private ComboBox VidCb;
        private ComboBox TeachIdCb;
        private ComboBox StudIdCb;
        private Label label5;
        private ComboBox AvtoCb;
        private DataGridView AbonDGV;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox8;
        private Label HomeTb;
        private PictureBox pictureBox1;
        private Label AboutTb;
        private PictureBox pictureBox6;
        private PictureBox pictureBox13;
        private PictureBox pictureBox3;
        private PictureBox pictureBox7;
        private Label logoutTb;
        private Label label10;
        private PictureBox pictureBox4;
        private Label AdminTb;
        private Label TeachTb;
        private PictureBox pictureBox5;
        private Label StudTb;
        private Button button1;
        private ComboBox UslugaId;
        private TextBox UsCost;
        private Label label4;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label6;
        private TextBox NameUs;
    }
}