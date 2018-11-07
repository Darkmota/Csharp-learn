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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 childForm = new Form1();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 childForm = new Form2();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 childForm = new Form3();
            childForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 childForm = new Form4();
            childForm.Show();
        }
    }
}
