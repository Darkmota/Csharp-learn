using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HC11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "435236234@gmail.com";
        }

        private void Check_Click(object sender, EventArgs e)
        {
            MatchCollection MC;
            string[] results = new string[20];
            int[] matchposition = new int[20];
            Regex r = new Regex(txtRegex.Text);
            MC = r.Matches(txtEmail.Text);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < MC.Count; i++)
            {
                results[i] = MC[i].Value;
                matchposition[i] = MC[i].Index;

                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = MC[i].Index.ToString();
                this.dataGridView1.Rows[index].Cells[1].Value = MC[i].Value;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtRegex.Text = @"((?:(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d))))";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtRegex.Text = @".+@.+\.\w+";
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
