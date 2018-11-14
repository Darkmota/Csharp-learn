using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HC8_3
{
    public partial class Form1 : Form
    {
        public static Graphics g;
        public static SolidBrush s = new SolidBrush(Color.Black);
        public static Pen p = new Pen(s, 2);
        public static Matrix m = new Matrix();
        public static Bitmap Bit = new Bitmap(Application.StartupPath + @"\picture.png");
        private void RefreshIt()
        {
            textBox1.Text = m.Elements[0].ToString();
            textBox2.Text = m.Elements[1].ToString();
            textBox3.Text = "0";
            textBox4.Text = m.Elements[2].ToString();
            textBox5.Text = m.Elements[3].ToString();
            textBox6.Text = "0";
            textBox7.Text = m.Elements[4].ToString();
            textBox8.Text = m.Elements[5].ToString();
            textBox9.Text = "1";
            // initialize
            g.ResetTransform();
            g.TranslateTransform(220, 220);
            g.ScaleTransform(-1, 1);

            g.DrawLine(p, new Point(-200, 0), new Point(200, 0));
            g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(0, -200), new Point(0, 200));
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshIt();
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            RefreshIt();
            g.MultiplyTransform(m);
            g.DrawImage(Bit, 0, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Matrix NewMateix = new Matrix((float)Convert.ToDouble(Text), m.Elements[1], m.Elements[2], m.Elements[3], m.Elements[4], m.Elements[5]);
            m = NewMateix;
            RefreshIt();
            g.MultiplyTransform(m);
            g.DrawImage(Bit, 0, 0);
        }
    }
}
