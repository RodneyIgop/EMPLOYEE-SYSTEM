using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPLOYEE_SYSTEM
{
    public partial class createAccFORM : Form
    {
        public createAccFORM()
        {
            InitializeComponent();
            createConfirmbtn.BackColor = Color.FromArgb(34, 46, 71);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usernameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwrdLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            mainForm loginForm = new mainForm();
           loginForm.Show();
            this.Hide();
        }

        private void passwrdTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void createAcc_Load(object sender, EventArgs e)
        {

        }
    }
}
