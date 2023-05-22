using AutoAcademy;
using DocumentFormat.OpenXml.Office2016.Drawing.Charts;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CrmAutoAcademy
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            DisplayAdm();
            if (Login.Role == "Teacher")
            {
                AdminTb.Enabled = false;
                TeachTb.Enabled = false;
                StudTb.Enabled = false;
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CrmAutoschool;Connect Timeout=30;");
        private void Delbtn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("Delete from AdminTbl where Admin_Id=@RKey ", Con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация удалена!");
                    Con.Close();
                    DisplayAdm();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void DisplayAdm()
        {
            Con.Open();
            string Query = "Select * from AdminTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AdminsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || RPhoneTB.Text == "" || RPassTb.Text == "")
            {
                MessageBox.Show("Не заполнены обязательные поля!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AdminTbl(AdminName,AdminPhone,AdminPass)values(@RN,@RP,@RPA)", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTB.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPassTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Пользователь добавлен!");
                    Con.Close();
                    DisplayAdm();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Не выбран пользователь или он не добавлен!");
            }
            else
            {


                if (RNameTb.Text == "" || RPhoneTB.Text == "" || RPassTb.Text == "")
                {
                    MessageBox.Show("Не заполнены обязательные поля!");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("update AdminTbl set AdminName=@RN,AdminPhone=@RP,AdminPass=@RPA where Admin_Id=@RKey", Con);
                        cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                        cmd.Parameters.AddWithValue("@RP", RPhoneTB.Text);
                        cmd.Parameters.AddWithValue("@RPA", RPassTb.Text);
                        cmd.Parameters.AddWithValue("@RKey", Key);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Информация обновлена!");
                        Con.Close();
                        DisplayAdm();
                        Clear();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int Key = 0;

        private void AdminsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RNameTb.Text = AdminsDGV.SelectedRows[0].Cells[1].Value.ToString();
            RPhoneTB.Text = AdminsDGV.SelectedRows[0].Cells[2].Value.ToString();
            RPassTb.Text = AdminsDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (RNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AdminsDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }
        private void Clear()
        {
            RNameTb.Text = "";
            RPhoneTB.Text = "";
            RPassTb.Text = "";
            Key = 0;
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
            this.Hide();
        }

        private void logoutTb_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
