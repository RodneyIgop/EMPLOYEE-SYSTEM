using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EMPLOYEE_SYSTEM
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            loginbutton.BackColor = Color.FromArgb(34, 46, 71);
            signupbtn.BackColor = Color.FromArgb(34, 46, 71);
            forgetpassbtn.BackColor = Color.FromArgb(34,46, 71);
        }

      


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DASHBOARD dashboard = new DASHBOARD();
            dashboard.Show();
            this.Hide();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dnthvaccLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void passwrdLabel_Click(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            createAccFORM createaccount = new createAccFORM();
            createaccount.Show();
            this.Hide();

        }

        private void usernameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwrdTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            forgetpass forgetpassword = new forgetpass();
            forgetpassword.Show();
            this.Hide();
        }

        private void mainpanel_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=emsystemdb;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
