using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace HC10
{
    public partial class Form1 : Form
    {
        static public string _filePath;
        static public SQLiteConnection _connection = null;
        static public DataSet _dataSet;
        static public SQLiteDataAdapter _dataAdapter = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFIle_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _filePath = openFileDialog1.FileName;

                _connection = new SQLiteConnection("Data Source=" + _filePath);

                _connection.Open();

                if (_connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("数据库打开成功");
                    string cmd = "select * from addressbook";
                    _dataAdapter = new SQLiteDataAdapter(cmd, _connection);

                }
                else
                {
                    MessageBox.Show("数据库打开失败");
                }
            }
        }
    }
}
