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
    public partial class forgetpass : Form
    {
        public forgetpass()
        {
            InitializeComponent();
            createConfirmbtn.BackColor = Color.FromArgb(34, 46, 71);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createConfirmbtn_Click(object sender, EventArgs e)
        {
            newpass npass = new newpass();
            npass.ShowDialog();
            this.Hide();


        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
    }

