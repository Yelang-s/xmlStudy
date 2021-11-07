using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xmlStudy
{
    public class WRXml
    {
        public static void WriteXml(Parameters parameters)
        {
            XmlDocument document = new XmlDocument();
            XmlDeclaration declaration = document.CreateXmlDeclaration("1.0", "utf-8", "yes");
            document.AppendChild(declaration);
            XmlElement root = document.CreateElement("Parameters");
            document.AppendChild(root);

            XmlElement system = document.CreateElement("System");
            system.SetAttribute("name", "system parameters");
            root.AppendChild(system);

            Type type = parameters.GetType();
            foreach (var name in type.GetProperties())
            {
                XmlElement xmlElement1 = document.CreateElement(name.Name);
                xmlElement1.InnerText = name.GetValue(parameters).ToString();
                system.AppendChild(xmlElement1);
            }
            document.Save("parameters.xml");
        }

        public static void ReadXml(out Parameters parameters)
        {
            parameters = new Parameters();
            Type type = parameters.GetType();
            XmlDocument document = new XmlDocument();
            document.Load("parameters.xml");
            XmlNode root = document.SelectSingleNode("Parameters");
            XmlNode node1 = root.SelectSingleNode("System");
            foreach (XmlNode cliendNode in node1.ChildNodes)
            {
                foreach (var item in type.GetProperties())
                {
                    if (cliendNode.Name == item.Name)
                    {
                        if (item.PropertyType == typeof(bool))
                        {
                            item.SetValue(parameters, Convert.ToBoolean(cliendNode.InnerText));
                        }
                        else
                        {
                            item.SetValue(parameters, cliendNode.InnerText);
                        }
                    }
                }
            }
        }
    }
}
