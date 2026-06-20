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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace blood_donation_org
{
    public partial class Form9 : Form
    {





        string Gender;
        string Are_you;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=SHASHINI\\SQLEXPRESS;Initial Catalog=blood donation;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Details Set Name=@Name,ID=@ID,Age=@Age,Gender=@Gender,BloodGroup=@BloodGroup,Address=@Address,Telephone=@Telephone,Are you=@Are you");
                cmd.Parameters.AddWithValue("@Name",textBox1.Text);
                cmd.Parameters.AddWithValue("@ID", textBox2.Text);
                cmd.Parameters.AddWithValue("@Age", textBox3.Text);
                cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                cmd.Parameters.AddWithValue("@Telephone", textBox5.Text);
                cmd.Parameters.AddWithValue("@Gender", textBox8.Text);
                cmd.Parameters.AddWithValue("@BloodGroup", textBox6.Text);
                cmd.Parameters.AddWithValue("@Areyou", textBox7.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

               

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);

                
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SHASHINI\\SQLEXPRESS;Initial Catalog=blood donation;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BloodDonationorg", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SHASHINI\\SQLEXPRESS;Initial Catalog=blood donation;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BloodDonationorg", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SHASHINI\\SQLEXPRESS;Initial Catalog=blood donation;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Name],[ID],[Age],[Gender],[Blood Group],[Address],[Telephone],[Are you]FROM [dbo].[BloodDonationorg]", con);
            cmd.Parameters.AddWithValue("ID", textBox1.Text);
            SqlDataReader da = cmd.ExecuteReader();
            if(da.Read())
                MessageBox.Show("Record Found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
              textBox1.Text= da.GetValue(0).ToString();
              textBox2.Text = da.GetValue(1).ToString();
              textBox3.Text = da.GetValue(2).ToString();
              textBox8.Text = da.GetValue(3).ToString();
            textBox6.Text = da.GetValue(4).ToString();
            textBox4.Text = da.GetValue(5).ToString();
            textBox5.Text = da.GetValue(6).ToString();
            textBox7.Text = da.GetValue(7).ToString();

             
            
              
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

