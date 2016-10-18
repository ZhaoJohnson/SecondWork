using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyTools
{
    public static  class XmlReader
    {

        public static List<Action> Read(string propertyName)
        {
            string TheBasePath = AppDomain.CurrentDomain.BaseDirectory;
            var myxmlName = ConfigurationSettings.AppSettings["myXml"].ToString();
            string fullPath = Path.Combine(TheBasePath, myxmlName);
            XmlDocument xmlRead=new XmlDocument();
            xmlRead.Load(fullPath);
            XmlNodeList xmlNodeList = xmlRead.SelectSingleNode("ShowAction").ChildNodes;
            List<Action> result= (from XmlNode list in xmlNodeList where list.Name == propertyName from XmlElement child in list.ChildNodes select (Action) (() => Console.WriteLine(child.InnerText))).ToList();
            return result;
        }

    }
}
