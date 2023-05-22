namespace CrmAutoAcademy
{
    partial class Usluga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usluga));
            UsNameTb = new TextBox();
            UsCostTb = new TextBox();
            UslugDGV = new DataGridView();
            EditBtn = new Button();
            DelBtn = new Button();
            AddBtn = new Button();
            panel2 = new Panel();
            HomeTb = new Label();
            pictureBox12 = new PictureBox();
            pictureBox8 = new PictureBox();
            label13 = new Label();
            logoutTb = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)UslugDGV).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UsNameTb
            // 
            UsNameTb.Location = new Point(235, 117);
            UsNameTb.Name = "UsNameTb";
            UsNameTb.Size = new Size(214, 23);
            UsNameTb.TabIndex = 0;
            // 
            // UsCostTb
            // 
            UsCostTb.Location = new Point(518, 117);
            UsCostTb.Name = "UsCostTb";
            UsCostTb.Size = new Size(218, 23);
            UsCostTb.TabIndex = 1;
            // 
            // UslugDGV
            // 
            UslugDGV.AllowUserToAddRows = false;
            UslugDGV.AllowUserToDeleteRows = false;
            UslugDGV.BackgroundColor = Color.White;
            UslugDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UslugDGV.GridColor = Color.Gray;
            UslugDGV.Location = new Point(235, 203);
            UslugDGV.MultiSelect = false;
            UslugDGV.Name = "UslugDGV";
            UslugDGV.RowTemplate.Height = 25;
            UslugDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UslugDGV.Size = new Size(501, 290);
            UslugDGV.TabIndex = 55;
            UslugDGV.CellContentClick += UslugDGV_CellContentClick_1;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(633, 161);
            EditBtn.Name = "EditBtn";
            EditBtn.RightToLeft = RightToLeft.No;
            EditBtn.Size = new Size(103, 36);
            EditBtn.TabIndex = 54;
            EditBtn.Text = "Редактировать";
            EditBtn.UseMnemonic = false;
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.Location = new Point(431, 161);
            DelBtn.Name = "DelBtn";
            DelBtn.RightToLeft = RightToLeft.No;
            DelBtn.Size = new Size(103, 36);
            DelBtn.TabIndex = 53;
            DelBtn.Text = "Удалить";
            DelBtn.UseMnemonic = false;
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(235, 161);
            AddBtn.Name = "AddBtn";
            AddBtn.RightToLeft = RightToLeft.No;
            AddBtn.Size = new Size(103, 36);
            AddBtn.TabIndex = 52;
            AddBtn.Text = "Добавить";
            AddBtn.UseMnemonic = false;
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(HomeTb);
            panel2.Controls.Add(pictureBox12);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(logoutTb);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 511);
            panel2.TabIndex = 56;
            // 
            // HomeTb
            // 
            HomeTb.AutoSize = true;
            HomeTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            HomeTb.Location = new Point(85, 150);
            HomeTb.Name = "HomeTb";
            HomeTb.Size = new Size(83, 24);
            HomeTb.TabIndex = 70;
            HomeTb.Text = "Главная";
            HomeTb.Click += HomeTb_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(12, 437);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(26, 40);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 55;
            pictureBox12.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 140);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(67, 48);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 69;
            pictureBox8.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(53, 113);
            label13.Name = "label13";
            label13.Size = new Size(95, 24);
            label13.TabIndex = 68;
            label13.Text = "Разделы:";
            // 
            // logoutTb
            // 
            logoutTb.AutoSize = true;
            logoutTb.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            logoutTb.Location = new Point(44, 444);
            logoutTb.Name = "logoutTb";
            logoutTb.Size = new Size(68, 24);
            logoutTb.TabIndex = 56;
            logoutTb.Text = "Выход";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-124, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 91);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 57;
            label1.Text = "Название услуги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(521, 92);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 58;
            label2.Text = "Стоимость";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(431, 46);
            label3.Name = "label3";
            label3.Size = new Size(88, 26);
            label3.TabIndex = 59;
            label3.Text = "Услуги";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(337, 9);
            label4.Name = "label4";
            label4.Size = new Size(312, 28);
            label4.TabIndex = 60;
            label4.Text = "Срм система Авто-Академия";
            // 
            // Usluga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 511);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(UslugDGV);
            Controls.Add(EditBtn);
            Controls.Add(DelBtn);
            Controls.Add(AddBtn);
            Controls.Add(UsCostTb);
            Controls.Add(UsNameTb);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Usluga";
            Text = "Услуги";
            ((System.ComponentModel.ISupportInitialize)UslugDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsNameTb;
        private TextBox UsCostTb;
        private DataGridView UslugDGV;
        private Button EditBtn;
        private Button DelBtn;
        private Button AddBtn;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox12;
        private Label logoutTb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label HomeTb;
        private PictureBox pictureBox8;
        private Label label13;
    }
}