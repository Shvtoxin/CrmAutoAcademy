using AutoAcademy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmAutoAcademy
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            if (Login.Role == "Admin")
            {
                AdminTb.Enabled = false;
                TeachTb.Enabled = false;
                UslugTb.Enabled = false;
            }
            else if (Login.Role == "Teacher")
            {
                Abonement obj = new Abonement();
                obj.Show();
                this.Hide();
                AdminTb.Enabled = false;
                TeachTb.Enabled = false;
                StudTb.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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
