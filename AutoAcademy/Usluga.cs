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
    public partial class Usluga : Form
    {
        public Usluga()
        {
            InitializeComponent();
            DisplayUslug();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CrmAutoschool;Connect Timeout=30;");
        int Key = 0;
        private void DisplayUslug()
        {
            Con.Open();
            string Query = "Select * from UslugTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UslugDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            UsNameTb.Text = "";
            UsCostTb.Text = "";
            Key = 0;
        }
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите услугу!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from UslugTbl where Id_Uslug=@RKey ", Con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация удалена!");
                    Con.Close();
                    DisplayUslug();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (UsNameTb.Text == "" || UsCostTb.Text == "")
            {
                MessageBox.Show("Не заполнены обязательные поля!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UslugTbl(Name_Us,Cost_Us)values(@NU,@CU)", Con);
                    cmd.Parameters.AddWithValue("@NU", UsNameTb.Text);
                    cmd.Parameters.AddWithValue("@CU", UsCostTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Услуга добавлена!");
                    Con.Close();
                    DisplayUslug();
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
                MessageBox.Show("Не выбрана услуга или она не добавлена!");
            }
            else
            {


                if (UsNameTb.Text == "" || UsCostTb.Text == "")
                {
                    MessageBox.Show("Не заполнены обязательные поля!");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("update UslugTbl set Name_Us=@NU,Cost_Us=@CU where Id_Uslug=@RKey", Con);
                        cmd.Parameters.AddWithValue("@NU", UsNameTb.Text);
                        cmd.Parameters.AddWithValue("@CU", UsCostTb.Text);
                        cmd.Parameters.AddWithValue("@RKey", Key);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Информация обновлена!");
                        Con.Close();
                        DisplayUslug();
                        Clear();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }

        private void UslugDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            UsNameTb.Text = UslugDGV.SelectedRows[0].Cells[1].Value.ToString();
            UsCostTb.Text = UslugDGV.SelectedRows[0].Cells[2].Value.ToString();



            if (UsNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(UslugDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void HomeTb_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }
    }
}
