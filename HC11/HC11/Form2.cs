using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace HC11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void startSpider_Click(object sender, EventArgs e)
        {
            string url = textURL.Text;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            HttpWebResponse res = null;
            Stream st = null;
            StreamReader sr = null;
            string html = string.Empty;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                st = res.GetResponseStream();
                sr = new StreamReader(st, System.Text.Encoding.UTF8);
                html = sr.ReadToEnd();
                txtHtml.Text = html;
                MatchCollection MC, MC2;
                string[] results = new string[20];
                int[] matchposition = new int[20];
                Regex r = new Regex("src=\".+?\"");
                Regex r2 = new Regex(@"http(|s):\/\/");
                MC = r.Matches(textURL.Text);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < MC.Count; i++)
                {
                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells[0].Value = MC[i].Value;
                }
            }
            catch (IOException ex)
            {
                textURL.Text = ex.Message;
            }
            finally
            {
                if (res != null)
                {
                    res.Close();
                }
                if (st != null)
                {
                    st.Close();
                }
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
