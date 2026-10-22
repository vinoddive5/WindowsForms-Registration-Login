using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterPage
{
    public partial class AllignementPage : Form
    {
        public AllignementPage(string username)
        {
            InitializeComponent();
            textBox1.Text = username;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                textBox1.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                textBox1.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            {

                textBox1.TextAlign = HorizontalAlignment.Right;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked)
            {
                textBox1.ForeColor = Color.Green;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked)
            {
                textBox1.ForeColor = Color.Yellow;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton6.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
