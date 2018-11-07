using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace HC4
{
    public partial class Form3 : Form
    {
        private bool started = false;
        private Stopwatch GoodTimer = new Stopwatch();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            started = true;
            GoodTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void Form3_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (GoodTimer.Elapsed.TotalMilliseconds >= 5000)
            {
                started = false;
                MessageBox.Show("OVER 5 SECONDS!");
            }
            GoodTimer.Stop();
            GoodTimer.Reset();
        }
    }
}
