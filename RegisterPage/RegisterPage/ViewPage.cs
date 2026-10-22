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
    public partial class View : Form
    {
        public string user;
        public View()
        {
            InitializeComponent();
        }
        public View(string a)
        {
            user = a;
            InitializeComponent();
  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            AllignementPage obj = new AllignementPage(user);
            obj.Show();
        }

        private void ViewPage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Database = Project; integrated security = true");
            string query = "SELECT * FROM EMPLOYEE WHERE USERNAME=@USERNAME";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@USERNAME", user);
            DataSet ds = new DataSet();
            da.Fill(ds, "EMPLOYEE");
            dataGridView1.DataSource = ds.Tables["EMPLOYEE"];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
