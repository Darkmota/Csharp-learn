using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
namespace HC9_1
{
    public partial class Form1 : Form {
        public int EditIndex;
        public bool EditMode = false;
        public DataSet DS = new DataSet();
        public XmlDocument XD;
        public string path = @"X:\about.net\example\XmlExample\1.xml";
        public static Fruit[] FruitsData = new Fruit[]
        {
            new Fruit(
                "苹果",10.0f,"烟台","一级","30天"
            ),
            new Fruit(
                "香蕉",5.5f,"广东","特级","14天"
            ),
            new Fruit(
                "柑橘",12.0f,"赣南","一级","60天"
            )
        };
        public ArrayList Fruits = new ArrayList(FruitsData);
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateXML()
        {
            XD = new XmlDocument();
            XD.CreateXmlDeclaration("1.0", "utf-8", "yes");
            XmlNode rootNode = XD.CreateElement("水果");
            foreach (Fruit f in Fruits)
            {
                f.InsertNode(XD, rootNode);
            }
            XD.AppendChild(rootNode);
            XMLBox.AppendText(XD.InnerXml);
            XD.Save(@"D:\test.xml");
        }
        private void CreateXMLButton_Click(object sender, EventArgs e)
        {
            UpdateXML();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Fruits.Add(new Fruit(txtName.Text.ToString(), Convert.ToDouble(txtPrice.Text), txtFrom.Text.ToString(), txtLevel.Text.ToString(), txtDate.Text.ToString()));
            UpdateXML();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DS.ReadXml(@"D:\test.xml", XmlReadMode.Auto);
            DataTable dt = new DataTable();
            dt.ReadXml
            foreach (DataTable DT in DS.Tables)
            {
                Console.WriteLine(DT);
                for (int i = 0; i < DT.Columns.Count; ++i)
                    Console.Write("\t" + DT.Columns[i].ColumnName.Substring(0, Math.Min(6, DT.Columns[i].ColumnName.Length)));
                Console.WriteLine();
                foreach (var row in DT.AsEnumerable())
                {
                    for (int i = 0; i < DT.Columns.Count; ++i)
                    {
                        Console.Write("\t" + row[i]);
                    }
                    Console.WriteLine();
                }
                DataRow[] Rows = DT.Select(@"价格='10'");
                foreach (var Row in Rows)
                {
                    for (int i = 0; i < 1; ++i)
                    {
                        Console.Write("\t<" + Row[i] + ">");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
