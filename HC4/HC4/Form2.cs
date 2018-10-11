using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HC4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void n2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void n3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void n4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void n5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void n6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void n7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void n8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void n9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] != '0')
            {
                textBox1.Text += '0';
            }
        }
        
        private void point_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text += '.';
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox1.Text += '+';
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox1.Text += '-';
        }

        private void time_Click(object sender, EventArgs e)
        {
            textBox1.Text += '*';
        }

        private void div_Click(object sender, EventArgs e)
        {
            textBox1.Text += '/';
        }

        private void eq_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                textBox1.Text = dt.Compute(textBox1.Text, "").ToString();
            }
            catch(Exception err)
            {
                textBox1.Text = err.Message;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
    }
}
