using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace RegisterPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            int Userid = random.Next(100000, 999999);

            userid.Text = Userid.ToString();
        }

        LoginPage log = new LoginPage();
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) ||
                 string.IsNullOrWhiteSpace(firstname.Text) ||
                 string.IsNullOrWhiteSpace(lastname.Text) ||
                 string.IsNullOrWhiteSpace(age.Text) ||
                 string.IsNullOrWhiteSpace(email.Text) ||
                 string.IsNullOrWhiteSpace(phone.Text) ||
                 string.IsNullOrWhiteSpace(address.Text) ||
                 string.IsNullOrWhiteSpace(password.Text) ||
                string.IsNullOrWhiteSpace(confirmpass.Text))
                 {
                         MessageBox.Show("Please fill all information");
                        return;
                 }
            int Userid = Convert.ToInt32(userid.Text);
            userid.Text = Userid.ToString();

            string Username = username.Text;

            string Firstname = firstname.Text;
            string Lastname = lastname.Text;

            string Gender = "";
            if(radioButton1.Checked)
            {
                Gender = "Male";
            } 
            else if(radioButton2.Checked)
            {

                Gender = "Female";
            }
            else 
            {
                Gender = "Others";
            }

            int Age = Convert.ToInt32(age.Text);

            string Email = email.Text;
            string Phone = phone.Text;

            string Address = address.Text;
            string Country = comboBox1.Text;

            string Language = "";
            if(checkBox1.Checked)
            {
                Language += "Marathi"+",";
            }

            if(checkBox2.Checked)
            {

                Language += "Hindi"+",";
            }

            if(checkBox3.Checked)
            {
                Language += "English"+",";
            }

            if(checkBox4.Checked)
            {
                Language += "Telugu";
            }

            string Password = password.Text;
            string ConfirmPassword = confirmpass.Text;
         
            SqlConnection con = new SqlConnection("Data Source=.; DataBase = Project; integrated security=true");
            con.Open();

            string query = "INSERT INTO EMPLOYEE VALUES(@USERID, @USERNAME, @FIRSTNAME, @LASTNAME, @GENDER, @AGE, @EMAIL, @PHONE, @ADDRESS, @COUNTRY, @LANGUAGE, @PASSWORD, @CONFIRMPASSWORD)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@USERID",Userid);
            cmd.Parameters.AddWithValue("@USERNAME", Username);
            cmd.Parameters.AddWithValue("@FIRSTNAME", Firstname);
            cmd.Parameters.AddWithValue("@LASTNAME", Lastname);
            cmd.Parameters.AddWithValue("@GENDER", Gender);
            cmd.Parameters.AddWithValue("@AGE", Age);
            cmd.Parameters.AddWithValue("@EMAIL", Email);
            cmd.Parameters.AddWithValue("@PHONE", Phone);
            cmd.Parameters.AddWithValue("@ADDRESS", Address);
            cmd.Parameters.AddWithValue("@COUNTRY", Country);
            cmd.Parameters.AddWithValue("@LANGUAGE", Language);
            cmd.Parameters.AddWithValue("@PASSWORD", Password);
            cmd.Parameters.AddWithValue("@CONFIRMPASSWORD", ConfirmPassword);

            cmd.ExecuteNonQuery();


            con.Close();

            log.Show();
        }

        private void userid_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> codes = new Dictionary<string, string>()
         {
             {"India", "+91"},
             {"USA", "+1"},
             {"Japan", "+81"},
             {"South Korea", "+82"},
             {"Indonesia", "+62"},
             {"Australia", "+61"},
             {"Germany", "+49"},
             {"United Kingdom", "+44"},
             {"Spain", "+34"},
             {"Ethiopia", "+251"},
             {"Peru", "+51"},
             {"Canada", "+1"}
          };

            if (codes.ContainsKey(comboBox1.Text))
            {
                phone.Text = codes[comboBox1.Text] + " ";
                phone.SelectionStart = phone.Text.Length;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userid.Clear();
            username.Clear();
            firstname.Clear();
            lastname.Clear();
            age.Clear();
            email.Clear();
            phone.Clear();
            address.Clear();
            password.Clear();
            confirmpass.Clear();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
