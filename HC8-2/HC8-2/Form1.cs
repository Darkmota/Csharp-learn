using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HC8_2
{
    public partial class Form1 : Form
    {
        public static Graphics g;
        public static Font f = new Font("Consolas", 30);
        public static Color c = Color.Yellow;
        public static Bitmap Bit = new Bitmap(Application.StartupPath + @"\picture.png");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            g.DrawImage(Bit, 0, 0, 600, 489);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            g.DrawImage(Bit, 0, 0, 600, 489);
            g.DrawString(textBox1.Text, f, new SolidBrush(c), new Point(200, 200));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            f = fontDialog1.Font;
            g.DrawString(textBox1.Text, f, new SolidBrush(c), new Point(200, 200));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            c = colorDialog1.Color;
            g.DrawString(textBox1.Text, f, new SolidBrush(c), new Point(200, 200));
        }
    }
}
