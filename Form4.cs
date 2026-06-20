using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace blood_donation_org
{
    public partial class Form4 : Form
    {


        string Gender;
        string Are_you;
        public Form4()
        {
            InitializeComponent();

            
         
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=SHASHINI\\SQLEXPRESS;Initial Catalog=blood donation;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO BloodDonationorg VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+Gender+"','"+comboBox1.SelectedItem.ToString()+"','"+textBox4.Text+"','"+textBox5.Text+"','"+Are_you+"')",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Registereted", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                comboBox1.SelectedItem = null;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Are_you = "Donors";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Are_you = "Reception";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
