using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HC4
{
    public partial class Form4 : Form
    {

        private string txtName = "";
        private string filePath = "";//储存文件路径

        bool b = false;// b 判断是否为打开的文件
        bool s = true;// s 判断文本是否未保存

        public Form4()
        {
            InitializeComponent();
        }
        private void Openthe()
        {
            if (s == true)
            {
                this.OpenFile();
            }
            else
            {
                this.AskDialog();
                this.OpenFile();
            }
        }

        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "打开文本文档-记事本";
            //过滤文件，只显示文本文档格式的文件。
            ofd.Filter = "文本文档|*.txt|所有文档|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //声明一个文件流对象，用来存放读取的文件流对象。
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                //将文件名赋值给临时变量。
                txtName = ofd.FileName;
                //创建读取器，用来将文件流中的数据读取出来。
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                //通过读取器将文件流中的数据读取到文本框中。
                txtInput.Text = sr.ReadToEnd();
                //关闭读取器。
                sr.Close();
                //和关闭文件流。
                fs.Close();
                //由于文件读取原理，上面两项关闭必须操作，否则无法成功读取文件。
            }
            this.Text = txtName + "-记事本";
            b = true;
            s = true;
        }
        protected void Save()
        {
            if (b == true)
            {
                SaveFileDialog ofg = new SaveFileDialog();
                txtInput.SaveFile(txtName, RichTextBoxStreamType.PlainText);
                s = true;
            }
            else { SaveAs(); }
        }

        private void SaveAs()
        {
            SaveFileDialog ofd = new SaveFileDialog();
            //对话框提示标题文字。
            ofd.Title = "另存为-记事本";
            //保存文本文档，以.txt作为后缀名，如果有则不加，否则添加后缀.txt。
            ofd.Filter = "文本文档|*.txt|所有文档|*.*";
            ofd.FileName = "记事本-" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";  //保存文件名
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtInput.SaveFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                txtName = "";
                filePath = "";
                Text = "新建-记事本";
                this.txtInput.Text = "";
                s = true;
            }
        }
        private void Newfile()
        {  /* 新建文本，保存后清空text，s 的值会变为false，所以要把 s =true */
            if (b == true)//判断是否为打开的文件
            {
                this.AskDialog();
            }
            else
            {
                this.AskDialog();
            }
            Text = "新建-记事本";
            //清除储存的文件名
            txtName = "";
            //新建文本文档后应该把 b 设为 false
            b = false;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newfile();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            s = false;
        }
        private void AskDialog()
        {
            //如果文本未保存，提示保存
            if (s == false)    //(this.richTextBox1.Text != string.Empty)
            {
                DialogResult r = MessageBox.Show("是否保存当前文件？",
                    "温馨提示",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);

                /* 判断用户选择,若选择"是/Yes"，弹出保存文件的对话框
                 * 若选择"否/No",不弹对话框,直接清空内容
                 * 若选择"取消/Cancel",无动作 */
                if (r == DialogResult.Yes)
                {
                    // 保存文件
                    Save();
                }
                else if (r == DialogResult.No)
                {
                    // 用户选择不保存时将输入框中的内容清除
                    Text = "新建-记事本";
                    this.txtInput.Clear();
                    b = false;
                    s = true;
                }
            }
            else   //否则直接清空文本
            {
                this.txtInput.Text = "";
                s = true;
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void 修改颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建颜色对话框
            colorDialog1.ShowDialog();
            txtInput.SelectionColor = colorDialog1.Color;
        }

        private void 修改大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            { this.txtInput.Font = font.Font; }
        }

        private void 拷贝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtInput.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.txtInput.Paste();

        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.txtInput.Undo();

        }
    }
}
