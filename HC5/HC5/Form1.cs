using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HC5
{
    public partial class Form1 : Form
    {
        private SystemInfo Info = new SystemInfo();
        public Form1()
        {
            InitializeComponent();
            StringBuilder Str = new StringBuilder(string.Empty);
            Str.AppendFormat("OS: {0}\n", Info.);
            if (Environment.Is64BitOperatingSystem)
                Str.AppendFormat("\t\t  64 Bit Operating System\n");
            else
                Str.AppendFormat("\t\t  32 Bit Operating System\n");
            Str.AppendFormat("SystemDirectory:  {0}\n", Environment.SystemDirectory);
            Str.AppendFormat("ProcessorCount:  {0}\n", Environment.ProcessorCount);
            Str.AppendFormat("UserDomainName:  {0}\n", Environment.UserDomainName);
            Str.AppendFormat("UserName: {0}\n", Environment.UserName);
            richTextBox1.Text = Str.ToString();
        }
    }
}
