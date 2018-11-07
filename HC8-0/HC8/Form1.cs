using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HC8
{
    public partial class Form1 : Form
    {
        public static Graphics g;
        public static Pen p;
        public static Color c;
        public static SolidBrush s = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = new Pen(Color.Red, 2.0f);
            g.FillRectangle(s, 10, 10, 300, 300);
            g.DrawRectangle(p, 10, 10, 300, 300);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p = new Pen(Color.Blue, 2.0f);
            g.FillEllipse(s, 10, 10, 400, 300);
            g.DrawEllipse(p, 10, 10, 400, 300);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            s = new SolidBrush(Color.Red);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            s = new SolidBrush(Color.Green);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            s = new SolidBrush(Color.Blue);
        }
    }
}
