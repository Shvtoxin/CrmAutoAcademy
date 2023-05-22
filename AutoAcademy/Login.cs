using CrmAutoAcademy;
using Org.BouncyCastle.Utilities;
using System.Data;
using System.Data.SqlClient;

namespace AutoAcademy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearTb_Click(object sender, EventArgs e)
        {
            RolCb.SelectedIndex = -1;
            LogTb.Text = "";
            PassTb.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CrmAutoschool;Connect Timeout=30;");
        public static string Role;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (RolCb.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите вашу должность");
            }
            else if (RolCb.SelectedIndex == 0)
            {
                if (LogTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Введите имя и пароль");
                }
                else if (LogTb.Text == "Админ" && PassTb.Text == "491625")
                {
                    Role = "Sis-Admin";
                    Teacher Obj = new Teacher();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Не верное имя или пароль");
                }
            }
            else if (RolCb.SelectedIndex == 1)
            {
                if (LogTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Введите имя и пароль");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from TeacherTbl where Teach_Name=N'" + LogTb.Text + "' and Teach_Pass='" + PassTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Teacher";
                        Abonement Obj = new Abonement();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Учитель не найден");
                    }
                    Con.Close();
                }
            }
            else
            {
                if (LogTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Введите имя и пароль");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from AdminTbl where AdminName=N'" + LogTb.Text + "' and AdminPass='" + PassTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Admin";
                        Home Obj = new Home();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Администратор не найден");
                    }
                    Con.Close();
                }
            }
        }
    }
}