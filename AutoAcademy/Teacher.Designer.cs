namespace CrmAutoAcademy
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            label1 = new Label();
            TNameTB = new TextBox();
            label7 = new Label();
            TKatCb = new ComboBox();
            label6 = new Label();
            TeachDR = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            AddBtn = new Button();
            DelBtn = new Button();
            EditBtn = new Button();
            TPassTb = new TextBox();
            label11 = new Label();
            TeacherDGV = new DataGridView();
            TPhoneTB = new MaskedTextBox();
            panel3 = new Panel();
            UslugTb = new Label();
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
            panel1 = new Panel();
            BtnFiltr = new Button();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            BtnSbros = new Button();
            buttonSort = new Button();
            radioButtonUp = new RadioButton();
            radioButtonDown = new RadioButton();
            comboBox1 = new ComboBox();
            label4 = new Label();
            ExpBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TeacherDGV).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(482, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 28);
            label1.TabIndex = 13;
            label1.Text = "Срм система Авто-Академия";
            // 
            // TNameTB
            // 
            TNameTB.Location = new Point(249, 117);
            TNameTB.Name = "TNameTB";
            TNameTB.Size = new Size(212, 23);
            TNameTB.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(249, 86);
            label7.Name = "label7";
            label7.Size = new Size(131, 24);
            label7.TabIndex = 14;
            label7.Text = "Имя учителя*";
            // 
            // TKatCb
            // 
            TKatCb.FormattingEnabled = true;
            TKatCb.Items.AddRange(new object[] { "А", "В", "ВЕ", "С", "СЕ", "Д" });
            TKatCb.Location = new Point(499, 117);
            TKatCb.Name = "TKatCb";
            TKatCb.Size = new Size(212, 23);
            TKatCb.TabIndex = 17;
            TKatCb.Text = "Выберите категорию";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(482, 86);
            label6.Name = "label6";
            label6.Size = new Size(260, 24);
            label6.TabIndex = 18;
            label6.Text = "Препадоваемая категория*";
            // 
            // TeachDR
            // 
            TeachDR.Location = new Point(816, 117);
            TeachDR.Name = "TeachDR";
            TeachDR.Size = new Size(200, 23);
            TeachDR.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(816, 86);
            label8.Name = "label8";
            label8.Size = new Size(159, 24);
            label8.TabIndex = 20;
            label8.Text = "Дата рождения*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(249, 152);
            label9.Name = "label9";
            label9.Size = new Size(99, 24);
            label9.TabIndex = 21;
            label9.Text = "Телефон*";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1045, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(249, 233);
            AddBtn.Name = "AddBtn";
            AddBtn.RightToLeft = RightToLeft.No;
            AddBtn.Size = new Size(147, 34);
            AddBtn.TabIndex = 25;
            AddBtn.Text = "Добавить";
            AddBtn.UseMnemonic = false;
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.Location = new Point(564, 233);
            DelBtn.Name = "DelBtn";
            DelBtn.RightToLeft = RightToLeft.No;
            DelBtn.Size = new Size(147, 34);
            DelBtn.TabIndex = 26;
            DelBtn.Text = "Удалить";
            DelBtn.UseMnemonic = false;
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(869, 233);
            EditBtn.Name = "EditBtn";
            EditBtn.RightToLeft = RightToLeft.No;
            EditBtn.Size = new Size(147, 34);
            EditBtn.TabIndex = 27;
            EditBtn.Text = "Редактировать";
            EditBtn.UseMnemonic = false;
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // TPassTb
            // 
            TPassTb.Location = new Point(499, 183);
            TPassTb.Name = "TPassTb";
            TPassTb.Size = new Size(212, 23);
            TPassTb.TabIndex = 29;
            TPassTb.Text = "Введите пароль";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(499, 152);
            label11.Name = "label11";
            label11.Size = new Size(85, 24);
            label11.TabIndex = 28;
            label11.Text = "Пароль*";
            // 
            // TeacherDGV
            // 
            TeacherDGV.AllowUserToAddRows = false;
            TeacherDGV.AllowUserToDeleteRows = false;
            TeacherDGV.BackgroundColor = Color.White;
            TeacherDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherDGV.GridColor = Color.Gray;
            TeacherDGV.Location = new Point(249, 273);
            TeacherDGV.MultiSelect = false;
            TeacherDGV.Name = "TeacherDGV";
            TeacherDGV.RowTemplate.Height = 25;
            TeacherDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TeacherDGV.Size = new Size(767, 187);
            TeacherDGV.TabIndex = 51;
            TeacherDGV.CellContentClick += TeacherDGV_CellContentClick;
            // 
            // TPhoneTB
            // 
            TPhoneTB.Location = new Point(249, 185);
            TPhoneTB.Mask = "+7000-000-00-00";
            TPhoneTB.Name = "TPhoneTB";
            TPhoneTB.Size = new Size(212, 23);
            TPhoneTB.TabIndex = 52;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(UslugTb);
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
            panel3.TabIndex = 53;
            // 
            // UslugTb
            // 
            UslugTb.AutoSize = true;
            UslugTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UslugTb.Location = new Point(85, 388);
            UslugTb.Name = "UslugTb";
            UslugTb.Size = new Size(71, 24);
            UslugTb.TabIndex = 43;
            UslugTb.Text = "Услуги";
            UslugTb.Click += UslugTb_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 375);
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
            HomeTb.Location = new Point(85, 118);
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
            AboutTb.Location = new Point(85, 440);
            AboutTb.Name = "AboutTb";
            AboutTb.Size = new Size(85, 24);
            AboutTb.TabIndex = 39;
            AboutTb.Text = "Справка";
            AboutTb.Click += AboutTb_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 314);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(67, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(12, 440);
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
            pictureBox7.Location = new Point(12, 107);
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
            label10.Location = new Point(62, 80);
            label10.Name = "label10";
            label10.Size = new Size(95, 24);
            label10.TabIndex = 37;
            label10.Text = "Разделы:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 169);
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
            AdminTb.Location = new Point(85, 325);
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
            TeachTb.Location = new Point(85, 190);
            TeachTb.Name = "TeachTb";
            TeachTb.Size = new Size(84, 24);
            TeachTb.TabIndex = 32;
            TeachTb.Text = "Учителя";
            TeachTb.Click += TeachTb_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 240);
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
            StudTb.Location = new Point(85, 255);
            StudTb.Name = "StudTb";
            StudTb.Size = new Size(99, 24);
            StudTb.TabIndex = 34;
            StudTb.Text = "Студенты";
            StudTb.Click += StudTb_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnFiltr);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(249, 486);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 143);
            panel1.TabIndex = 54;
            // 
            // BtnFiltr
            // 
            BtnFiltr.Location = new Point(95, 111);
            BtnFiltr.Name = "BtnFiltr";
            BtnFiltr.Size = new Size(117, 23);
            BtnFiltr.TabIndex = 3;
            BtnFiltr.Text = "Фильтровать";
            BtnFiltr.UseVisualStyleBackColor = true;
            BtnFiltr.Click += BtnFiltr_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "А", "В", "ВЕ", "С", "СЕ", "Д" });
            comboBox2.Location = new Point(14, 76);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(264, 23);
            comboBox2.TabIndex = 2;
            comboBox2.Text = "Фильтровать по категории";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Введите запрос";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 5);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Поиск";
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnSbros);
            panel2.Controls.Add(buttonSort);
            panel2.Controls.Add(radioButtonUp);
            panel2.Controls.Add(radioButtonDown);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(713, 486);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 143);
            panel2.TabIndex = 55;
            // 
            // BtnSbros
            // 
            BtnSbros.Location = new Point(183, 111);
            BtnSbros.Name = "BtnSbros";
            BtnSbros.Size = new Size(116, 23);
            BtnSbros.TabIndex = 7;
            BtnSbros.Text = "Сбросить";
            BtnSbros.UseVisualStyleBackColor = true;
            BtnSbros.Click += BtnSbros_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(13, 111);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(102, 23);
            buttonSort.TabIndex = 6;
            buttonSort.Text = "Сортировать";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // radioButtonUp
            // 
            radioButtonUp.AutoSize = true;
            radioButtonUp.Location = new Point(183, 82);
            radioButtonUp.Name = "radioButtonUp";
            radioButtonUp.Size = new Size(116, 19);
            radioButtonUp.TabIndex = 5;
            radioButtonUp.TabStop = true;
            radioButtonUp.Text = "По возрастанию";
            radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // radioButtonDown
            // 
            radioButtonDown.AutoSize = true;
            radioButtonDown.Location = new Point(13, 82);
            radioButtonDown.Name = "radioButtonDown";
            radioButtonDown.Size = new Size(102, 19);
            radioButtonDown.TabIndex = 4;
            radioButtonDown.TabStop = true;
            radioButtonDown.Text = "По убыванию";
            radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Имя", "Дата рождения", "Категории" });
            comboBox1.Location = new Point(13, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Выберите поле сортировки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 5);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 0;
            label4.Text = "Сортировка";
            // 
            // ExpBtn
            // 
            ExpBtn.Location = new Point(581, 529);
            ExpBtn.Name = "ExpBtn";
            ExpBtn.Size = new Size(92, 37);
            ExpBtn.TabIndex = 56;
            ExpBtn.Text = "Экспорт";
            ExpBtn.UseVisualStyleBackColor = true;
            ExpBtn.Click += ExpBtn_Click;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1089, 646);
            Controls.Add(ExpBtn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(TPhoneTB);
            Controls.Add(TeacherDGV);
            Controls.Add(TPassTb);
            Controls.Add(label11);
            Controls.Add(EditBtn);
            Controls.Add(DelBtn);
            Controls.Add(AddBtn);
            Controls.Add(pictureBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TeachDR);
            Controls.Add(label6);
            Controls.Add(TKatCb);
            Controls.Add(TNameTB);
            Controls.Add(label7);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Teacher";
            Text = "Teacher";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)TeacherDGV).EndInit();
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox TNameTB;
        private Label label7;
        private ComboBox TKatCb;
        private Label label6;
        private DateTimePicker TeachDR;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox2;
        private Button AddBtn;
        private Button DelBtn;
        private Button EditBtn;
        private TextBox TPassTb;
        private Label label11;
        private DataGridView TeacherDGV;
        private MaskedTextBox TPhoneTB;
        private Panel panel3;
        private Label UslugTb;
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
        private Panel panel1;
        private Button BtnFiltr;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label3;
        private Panel panel2;
        private Button BtnSbros;
        private Button buttonSort;
        private RadioButton radioButtonUp;
        private RadioButton radioButtonDown;
        private ComboBox comboBox1;
        private Label label4;
        private Button ExpBtn;
    }
}