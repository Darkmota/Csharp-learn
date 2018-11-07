using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HC8_1
{
    public partial class Form1 : Form
    {
        public static Graphics g;
        public static int[] data = { 20, 30, 40, 60, 90, 100, 70, 50, 30 ,20 };
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SolidBrush s1 = new SolidBrush(Color.Gray);
            SolidBrush s2 = new SolidBrush(Color.Blue);
            Pen p = new Pen(Color.Black, 5);
            for (int i = 0; i < 10; ++i)
            {
                g.FillRectangle(s1, i * 50 + 100, 400 - data[i] * 3, 40, data[i] * 3);
                g.FillRectangle(s2, i * 50 + 105, 400 - data[i] * 3 - 5, 40, data[i] * 3);
                g.DrawString(data[i].ToString(), new Font("Consolas", 16), new SolidBrush(Color.White), new Point(i * 50 + 100, 400 - data[i] * 3 - 3));
            }
            for (int i = 0; i <= 100; i += 10)
            {
                g.DrawString(i.ToString(), new Font("Consolas", 16), new SolidBrush(Color.Black), new Point(60, 390 - i * 3 - 3));
            }
            g.DrawLine(p, new Point(100, 400), new Point(700, 400));
            g.DrawLine(p, new Point(100, 40), new Point(100, 400));
        }
    }
}
