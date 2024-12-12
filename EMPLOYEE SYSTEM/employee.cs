using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EMPLOYEE_SYSTEM
{
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employees_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=emsystemdb;Uid=root;Pwd=;";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM employee_tbl"; // Replace 'employees' with your actual table name
                    MySqlDataAdapter adapt = new MySqlDataAdapter(query, con);

                    // Create a DataTable to hold the data
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);

                    // Assuming you have a DataGridView named `dataGridView1`
                    dataGridView2.DataSource = dt;

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void empAddbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
