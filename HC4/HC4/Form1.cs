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
    public partial class Form1 : Form
    {
        private void Enbutton()
        {
            button1.Enabled = listBox1.Items.Count != 0;
            button2.Enabled = listBox2.Items.Count != 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                Enbutton();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                Enbutton();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] names = { "糖醋排骨", "红烧狮子头", "烧花鸭", "烧雏鸡" };
            foreach (string name in names)
            {
                listBox1.Items.Add(name);
            }
            Enbutton();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
