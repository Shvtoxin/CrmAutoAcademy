using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using AutoAcademy;
using DocumentFormat.OpenXml.Office2016.Drawing.Charts;


namespace CrmAutoAcademy
{
    public partial class Students : Form
    {
        private string Query = "Select * from StudTbl";
        public Students()
        {
            InitializeComponent();
            DisplayStud(Query);
            if (Login.Role == "Teacher")
            {
                TeachTb.Enabled = false;
                AdminTb.Enabled = false;
                UslugTb.Enabled = false;
            }
            else if (Login.Role == "Admin")
            {
                TeachTb.Enabled = false;
                AdminTb.Enabled = false;
                UslugTb.Enabled = false;
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CrmAutoschool;Connect Timeout=30;");

        private void DisplayStud(string Query)
        {
            // получаем данные в DataSet через SqlDataAdapter
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //создаем объект DataSet
            var ds = new DataSet();
            //заполняем DataSet
            sda.Fill(ds);
            //отображаем данные
            StudDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            SNameTB.Text = "";
            SKatCB.SelectedIndex = -1;
            StudDR.Text = "";
            SPhoneTB.Text = "";
            SVidCB.SelectedIndex = -1;
            AvtoCb.SelectedIndex = -1;
            Key = 0;
        }
        int Key = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (SNameTB.Text == "" || SPhoneTB.Text == "" || SKatCB.SelectedIndex == -1 || SVidCB.SelectedIndex == -1 || AvtoCb.SelectedIndex == -1)
            {
                MessageBox.Show("Не заполнены обязательные поля!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudTbl(Stud_Name,Stud_Kat,Stud_Dr,Stud_Phone,Stud_vid,Stud_avto)values(@SN,@SK,@SD,@SP,@SV,@SA)", Con);
                    cmd.Parameters.AddWithValue("@SN", SNameTB.Text);
                    cmd.Parameters.AddWithValue("@SK", SKatCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SD", StudDR.Value.Date);
                    cmd.Parameters.AddWithValue("@SP", SPhoneTB.Text);
                    cmd.Parameters.AddWithValue("@SV", SVidCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SA", AvtoCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Студент добавлен!");
                    Con.Close();
                    DisplayStud(Query);
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Не выбран пользователь или он не добавлен!");
            }
            else
            {


                if (SNameTB.Text == "" || SPhoneTB.Text == "" || SKatCB.SelectedIndex == -1 || SVidCB.SelectedIndex == -1 || AvtoCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Не заполнены обязательные поля!");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("update StudTbl set Stud_Name=@SN,Stud_Kat=@SK,Stud_Dr=@SD,Stud_Phone=@SP,Stud_vid=@SV,Stud_avto=@SA  where Stud_Id=@RKey", Con);
                        cmd.Parameters.AddWithValue("@SN", SNameTB.Text);
                        cmd.Parameters.AddWithValue("@SK", SKatCB.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@SD", StudDR.Value.Date);
                        cmd.Parameters.AddWithValue("@SP", SPhoneTB.Text);
                        cmd.Parameters.AddWithValue("@SV", SVidCB.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@SA", AvtoCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@RKey", Key);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Информация обновлена!");
                        Con.Close();
                        DisplayStud(Query);
                        Clear();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите пользователя!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from StudTbl where Stud_Id=@RKey ", Con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация удалена!");
                    Con.Close();
                    DisplayStud(Query);
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void StudDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SNameTB.Text = StudDGV.SelectedRows[0].Cells[1].Value.ToString();
            SKatCB.SelectedItem = StudDGV.SelectedRows[0].Cells[2].Value.ToString();
            StudDR.Text = StudDGV.SelectedRows[0].Cells[3].Value.ToString();
            SPhoneTB.Text = StudDGV.SelectedRows[0].Cells[4].Value.ToString();
            SVidCB.SelectedItem = StudDGV.SelectedRows[0].Cells[5].Value.ToString();
            AvtoCb.SelectedItem = StudDGV.SelectedRows[0].Cells[6].Value.ToString();


            if (SNameTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StudDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }
        private Excel.Application GetExcel()
        {
            Excel.Application xlApp;
            Worksheet xlSheet;
            xlApp = new Excel.Application();
            Excel.Workbook wBook;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 15;
            xlSheet = wBook.Sheets[1];
            xlSheet.Name = "Студенты";
            xlSheet.Cells.HorizontalAlignment = 3;
            for (int j = 1; j < StudDGV.Columns.Count + 1; j++)
            {
                xlApp.Cells[1, j] = StudDGV.Columns[j - 1].HeaderText;
            }
            return xlApp;
        }


        private void ExpBtn_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Экспортировать все?", "Справка", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    {
                        var xlApp = GetExcel();
                        for (int i = 0; i < StudDGV.Rows.Count; i++)
                        {
                            for (int j = 0; j < StudDGV.Columns.Count; j++)
                            {
                                xlApp.Cells[i + 2, j + 1] = StudDGV.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        xlApp.Visible = true;
                        break;
                    };

                case DialogResult.No:
                    {
                        var xlApp = GetExcel();
                        for (int i = 0; i < StudDGV.SelectedRows.Count - 1; i++)
                        {
                            for (int j = 0; j < StudDGV.Columns.Count; j++)
                            {
                                xlApp.Cells[i + 2, j + 1] = StudDGV.SelectedRows[i].Cells[j].Value.ToString();
                            }
                        }
                        xlApp.Visible = true;
                        break;
                    };

                case DialogResult.Cancel:
                    return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < StudDGV.RowCount; i++)
            {
                for (int j = 0; j < StudDGV.ColumnCount; j++)
                {
                    StudDGV[j, i].Style.BackColor = Color.White;
                    StudDGV[j, i].Style.ForeColor = Color.Black;
                }
            }

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                StudDGV.ClearSelection();
                for (int i = 0; i < StudDGV.RowCount - 1; i++)
                {
                    for (int j = 0; j < StudDGV.ColumnCount; j++)
                    {
                        if (StudDGV[j, i].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                        {
                            StudDGV[j, i].Style.BackColor = Color.Black;
                            StudDGV[j, i].Style.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            var COL = new System.Windows.Forms.DataGridViewColumn();

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Имя":
                    COL = StudDGV.Columns["Stud_Name"];
                    break;
                case "Дата рождения":
                    COL = StudDGV.Columns["Stud_Dr"];
                    break;
                case "Категории":
                    COL = StudDGV.Columns["Stud_Kat"];
                    break;
                case "Вид обучения":
                    COL = StudDGV.Columns["Stud_vid"];
                    break;
                case "Автомобиль":
                    COL = StudDGV.Columns["Stud_avto"];
                    break;

            }
            if (radioButtonUp.Checked)
            {
                StudDGV.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                StudDGV.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void BtnSbros_Click(object sender, EventArgs e)
        {
            DisplayStud(Query);
            buttonSort.Enabled = true;
        }

        private void BtnFiltr_Click(object sender, EventArgs e)
        {
            DisplayStud(Query + " where Stud_Kat=N'" + comboBox2.SelectedItem.ToString() + "'");
            buttonSort.Enabled = false;
        }

        private void HomeTb_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void TeachTb_Click(object sender, EventArgs e)
        {
            Teacher obj = new Teacher();
            obj.Show();
            this.Hide();
        }

        private void StudTb_Click(object sender, EventArgs e)
        {
            Students obj = new Students();
            obj.Show();
            this.Hide();
        }

        private void AdminTb_Click(object sender, EventArgs e)
        {
            Admin obj = new Admin();
            obj.Show();
            this.Hide();

        }

        private void UslugTb_Click(object sender, EventArgs e)
        {
            Usluga obj = new Usluga();
            obj.Show();
        }

        private void AboutTb_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();
        }

        private void logoutTb_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
