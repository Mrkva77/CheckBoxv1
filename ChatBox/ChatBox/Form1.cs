using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
 
     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
        }

        public void radi()
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                textBox1.Text = "dorucak, rucak i vecera";
            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                textBox1.Text = "rucak i vecera";
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox1.Text = "dorucak i rucak";
            }
            else if (checkBox1.Checked && checkBox3.Checked)
            {
                textBox1.Text = "dorucak i vecera";
            }
            else if (checkBox1.Checked)
            {
                textBox1.Text = "dorucak";
            }
            else if (checkBox2.Checked)
            {
                textBox1.Text = "rucak";
            }
            else if (checkBox3.Checked)
            {
                textBox1.Text = "vecera";
            }
        }
        private void button1_Click(object sender, EventArgs e) => radi();
         
    private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox1.Visible = false;
            } else
            {
                textBox1.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

