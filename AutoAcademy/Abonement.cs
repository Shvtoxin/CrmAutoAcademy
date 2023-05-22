using AutoAcademy;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Office2016.Drawing.Charts;
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

namespace CrmAutoAcademy
{
    public partial class Abonement : Form
    {
        public Abonement()
        {
            InitializeComponent();
            DisplayAbon();
            if (Login.Role == "Teacher")
            {
                AdminTb.Enabled = false;
                TeachTb.Enabled = false;
                StudTb.Enabled = false;
            }
            GetUslugaId();
            GetStudId();
            GetTeachId();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        int Key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CrmAutoschool;Connect Timeout=30;");

        private void GetTeachName()
        {
            Con.Open();
            string Query = "Select * from TeacherTbl where Teach_Id=" + TeachIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                NameTeach.Text = dr["Teach_Name"].ToString();
            }
            Con.Close();
        }
        private void GetStudName()
        {
            Con.Open();
            string Query = "Select * from StudTbl where Stud_Id=" + StudIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                NameStud.Text = dr["Stud_Name"].ToString();
                VidCb.Text = dr["Stud_vid"].ToString();
                AvtoCb.Text = dr["Stud_avto"].ToString();
            }
            Con.Close();
        }
        private void GetUslugaName()
        {
            Con.Open();
            string Query = "Select * from UslugTbl where Id_Uslug=" + UslugaId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                NameUs.Text = dr["Name_Us"].ToString();
                UsCost.Text = dr["Cost_Us"].ToString();
            }
            Con.Close();
        }
        private void GetTeachId()
        {
            //получаем все id 
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select Teach_Id from TeacherTbl", Con);
            SqlDataReader rdr;
            // для получения строк из источника данных. 
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Teach_Id", typeof(int));
            dt.Load(rdr);
            //фактическое значение
            TeachIdCb.ValueMember = "Teach_Id";
            //задаем в комбобокс
            TeachIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetStudId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select Stud_Id from StudTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Stud_Id", typeof(int));
            dt.Load(rdr);
            StudIdCb.ValueMember = "Stud_Id";
            StudIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetUslugaId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select Id_Uslug from UslugTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id_Uslug", typeof(int));
            dt.Load(rdr);
            UslugaId.ValueMember = "Id_Uslug";
            UslugaId.DataSource = dt;
            Con.Close();
        }
        private void Clear()
        {

            NameStud.Text = "";
            NameTeach.Text = "";
            StudIdCb.SelectedIndex = -1;
            TeachIdCb.SelectedIndex = -1;
            VidCb.SelectedIndex = -1;
            AvtoCb.SelectedIndex = -1;
            Key = 0;
        }
        private void DisplayAbon()
        {
            Con.Open();
            string Query = "Select * from AbonementTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AbonDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StudTb.Text == "" || TeachTb.Text == "" || NameUs.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                //отлавливаем ошибку
                try
                {
                    //открываем подключение
                    Con.Open();
                    //создаем команду для добавления
                    SqlCommand cmd = new SqlCommand("insert into AbonementTbl(Stud_id,Stud_Name,Teach_id,Teach_Name,Stud_vid,Stud_avto,Id_Uslug,Name_Us,Cost_Us)values(@SI,@SN,@TI,@TN,@SV,@SA,@IU,@NU,@CU)", Con);
                    //добавляем значения в строку
                    cmd.Parameters.AddWithValue("@SI", StudIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SN", NameStud.Text);
                    cmd.Parameters.AddWithValue("@TI", TeachIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TN", NameTeach.Text);
                    cmd.Parameters.AddWithValue("@SV", VidCb.Text);
                    cmd.Parameters.AddWithValue("@SA", AvtoCb.Text);
                    cmd.Parameters.AddWithValue("@IU", UslugaId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@NU", NameUs.Text);
                    cmd.Parameters.AddWithValue("@CU", UsCost.Text);

                    cmd.ExecuteNonQuery();
                    // выполняет sql-выражение и возвращает количество измененных записей.
                    MessageBox.Show("отчет добавлен");
                    //закрываем подключение
                    Con.Close();
                    DisplayAbon();
                    Clear();
                }
                catch (Exception err)
                {
                    //показываем ошибку
                    MessageBox.Show(err.Message);
                }

            }
        }

        private void StudIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        private void TeachIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTeachName();
        }

        private void UslugaId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetUslugaName();
        }

        private void AbonDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AbonSumTxt.Text = "";
            AbonSumTxt.Text = "                         Автошкола Движение    \n\n" +
                "\n\n                              Абонемент                 " +
                "\n*******************************************************************************\n" +
                "\n" + DateTime.Today.Date + "\n\n\n\n                                                         " +
                "\n         Учитель: " + AbonDGV.SelectedRows[0].Cells[4].Value.ToString() + "\n\n                    " +
                "\n         Студент: " + AbonDGV.SelectedRows[0].Cells[2].Value.ToString() + "\n\n                    " +
                "\n         Услуга: " + AbonDGV.SelectedRows[0].Cells[8].Value.ToString() + "\n\n                     " +
                "\n         Вид обучения: " + AbonDGV.SelectedRows[0].Cells[5].Value.ToString() + "\n\n               " +
                "\n         Автомобиль: " + AbonDGV.SelectedRows[0].Cells[6].Value.ToString() + "\n\n                 " +
                "\n         Стоимость: " + AbonDGV.SelectedRows[0].Cells[9].Value.ToString() + " Руб.\n\n\n\n              ";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(AbonSumTxt.Text + "\n", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(98, 80));

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
