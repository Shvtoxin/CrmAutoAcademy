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

namespace CrmAutoAcademy
{
    public partial class Teacher : Form
    {
        private string Query = "Select * from TeacherTbl";
        public Teacher()
        {
            InitializeComponent();
            DisplayTeach(Query);
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CrmAutoschool;Connect Timeout=30;");
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DisplayTeach(string Query)
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
            TeacherDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            TNameTB.Text = "";
            TKatCb.SelectedIndex = -1;
            TeachDR.Text = "";
            TPhoneTB.Text = "";
            TPassTb.Text = "";
            Key = 0;
        }
        int Key = 0;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TNameTB.Text == "" || TPhoneTB.Text == "" || TPassTb.Text == "" || TKatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Не заполнены обязательные поля!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TeacherTbl(Teach_Name,Teach_Kat,Teach_Dr,Teach_Phone,Teach_Pass)values(@TN,@TK,@TD,@TP,@TPA)", Con);
                    cmd.Parameters.AddWithValue("@TN", TNameTB.Text);
                    cmd.Parameters.AddWithValue("@TK", TKatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TD", TeachDR.Value.Date);
                    cmd.Parameters.AddWithValue("@TP", TPhoneTB.Text);
                    cmd.Parameters.AddWithValue("@TPA", TPassTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Учитель добавлен!");
                    Con.Close();
                    DisplayTeach(Query);
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void TeacherDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TNameTB.Text = TeacherDGV.SelectedRows[0].Cells[1].Value.ToString();
            TKatCb.SelectedItem = TeacherDGV.SelectedRows[0].Cells[2].Value.ToString();
            TeachDR.Text = TeacherDGV.SelectedRows[0].Cells[3].Value.ToString();
            TPhoneTB.Text = TeacherDGV.SelectedRows[0].Cells[4].Value.ToString();
            TPassTb.Text = TeacherDGV.SelectedRows[0].Cells[5].Value.ToString();


            if (TNameTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TeacherDGV.SelectedRows[0].Cells[0].Value.ToString());

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
                    SqlCommand cmd = new SqlCommand("Delete from TeacherTbl where Teach_Id=@RKey ", Con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация удалена!");
                    Con.Close();
                    DisplayTeach(Query);
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


                if (TNameTB.Text == "" || TPhoneTB.Text == "" || TPassTb.Text == "" || TKatCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Не заполнены обязательные поля!");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("update TeacherTbl set Teach_Name=@TN,Teach_Kat=@TK,Teach_Dr=@TD,Teach_Phone=@TP,Teach_Pass=@TPA where Teach_Id=@RKey", Con);
                        cmd.Parameters.AddWithValue("@TN", TNameTB.Text);
                        cmd.Parameters.AddWithValue("@TK", TKatCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@TD", TeachDR.Value.Date);
                        cmd.Parameters.AddWithValue("@TP", TPhoneTB.Text);
                        cmd.Parameters.AddWithValue("@TPA", TPassTb.Text);
                        cmd.Parameters.AddWithValue("@RKey", Key);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Информация обновлена!");
                        Con.Close();
                        DisplayTeach(Query);
                        Clear();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
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
            xlSheet.Name = "Учителя";
            xlSheet.Cells.HorizontalAlignment = 3;
            for (int j = 1; j < TeacherDGV.Columns.Count + 1; j++)
            {
                xlApp.Cells[1, j] = TeacherDGV.Columns[j - 1].HeaderText;
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
                        for (int i = 0; i < TeacherDGV.Rows.Count; i++)
                        {
                            for (int j = 0; j < TeacherDGV.Columns.Count; j++)
                            {
                                xlApp.Cells[i + 2, j + 1] = TeacherDGV.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        xlApp.Visible = true;
                        break;
                    };

                case DialogResult.No:
                    {
                        var xlApp = GetExcel();
                        for (int i = 0; i < TeacherDGV.SelectedRows.Count - 1; i++)
                        {
                            for (int j = 0; j < TeacherDGV.Columns.Count; j++)
                            {
                                xlApp.Cells[i + 2, j + 1] = TeacherDGV.SelectedRows[i].Cells[j].Value.ToString();
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
            for (int i = 0; i < TeacherDGV.RowCount; i++)
            {
                for (int j = 0; j < TeacherDGV.ColumnCount; j++)
                {
                    TeacherDGV[j, i].Style.BackColor = Color.White;
                    TeacherDGV[j, i].Style.ForeColor = Color.Black;
                }
            }

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                TeacherDGV.ClearSelection();
                for (int i = 0; i < TeacherDGV.RowCount - 1; i++)
                {
                    for (int j = 0; j < TeacherDGV.ColumnCount; j++)
                    {
                        if (TeacherDGV[j, i].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                        {
                            TeacherDGV[j, i].Style.BackColor = Color.Black;
                            TeacherDGV[j, i].Style.ForeColor = Color.White;
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
                    COL = TeacherDGV.Columns["Teach_Name"];
                    break;
                case "Дата рождения":
                    COL = TeacherDGV.Columns["Teach_Dr"];
                    break;
                case "Категории":
                    COL = TeacherDGV.Columns["Teach_Kat"];
                    break;

            }
            if (radioButtonUp.Checked)
            {
                TeacherDGV.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                TeacherDGV.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void BtnSbros_Click(object sender, EventArgs e)
        {
            DisplayTeach(Query);
            buttonSort.Enabled = true;
        }

        private void BtnFiltr_Click(object sender, EventArgs e)
        {
            DisplayTeach(Query + " where Teach_Kat=N'" + comboBox2.SelectedItem.ToString() + "'");
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
