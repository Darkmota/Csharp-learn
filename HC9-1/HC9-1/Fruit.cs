using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace HC9_1
{
    public class Fruit
    {
        public string name;
        public double price;
        public string from;
        public string level;
        public string date;
        public Fruit(string n, double p, string f, string lv, string d)
        {
            name = n;
            price = p;
            from = f;
            level = lv;
            date = d;
        }
        public void InsertNode(XmlDocument XD, XmlNode XN)
        {
            XmlNode xmlNode = XD.CreateElement(name);
            XmlAttribute levelAttr = XD.CreateAttribute("等级");
            levelAttr.Value = level;
            XmlAttribute dateAttr = XD.CreateAttribute("保质期");
            dateAttr.Value = date;
            xmlNode.Attributes.Append(levelAttr);
            xmlNode.Attributes.Append(dateAttr);
            XmlNode priceNode = XD.CreateElement("价格");
            priceNode.InnerText = price.ToString();
            xmlNode.AppendChild(priceNode);
            XmlNode fromNode = XD.CreateElement("产地");
            fromNode.InnerText = from.ToString();
            xmlNode.AppendChild(fromNode);
            XmlNode weightNode = XD.CreateElement("单位");
            weightNode.InnerText = "千克";
            xmlNode.AppendChild(weightNode);
            XN.AppendChild(xmlNode);
            return;
        }
    }
}
