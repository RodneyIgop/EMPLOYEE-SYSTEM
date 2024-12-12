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
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
            new[] { dashboardbtn, employeesbtn, logsbtn, salarybtn, departmentbtn, attendancebtn }
             .ToList()
            .ForEach(btn => btn.BackColor = Color.FromArgb(113, 126, 167));
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(34, 46, 71);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm form1 = new mainForm();
            form1.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new SALARY());
        }

        private void DASHBOARD_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeesbtn_Click(object sender, EventArgs e)
        {
            loadform(new employees());
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            loadform(new DASHBOARD());
        }

        private void logsbtn_Click(object sender, EventArgs e)
        {
            loadform(new LOGS());
        }

        private void departmentbtn_Click(object sender, EventArgs e)
        {
            loadform(new DEPARTMENTS());
        }

        private void attendancebtn_Click(object sender, EventArgs e)
        {
            loadform(new ATTENDANCE());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

       
    }
}
