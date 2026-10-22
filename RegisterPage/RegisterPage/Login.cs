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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;

            SqlConnection con = new SqlConnection("Data Source=.; Database = Project; integrated security = true");
            con.Open();

            string query = "SELECT COUNT(*) FROM EMPLOYEE WHERE Username = @USERNAME AND Password = @PASSWORD";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@USERNAME", Username);
            cmd.Parameters.AddWithValue("@PASSWORD", Password);

            int c = Convert.ToInt32(cmd.ExecuteScalar());
            if(c==0)
            {
                MessageBox.Show("Invalid Username or Password");
            }
            else
            {
                View obj = new View(username.Text);
                obj.Show();
            }


        }
    }
}
