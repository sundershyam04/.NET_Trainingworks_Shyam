using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FileHandling
{
    internal class xml
    {

        static void Main(string[] args)
        {
            //FileStream fs=new FileStream("Emp.xml",FileMode.Open,FileAccess.Write);

            XMLcreatewrite();

            XMLread();

        }

        private static void XMLread()
        {
            FileStream fs = new FileStream("employee.xml", FileMode.Open, FileAccess.Read);
            XmlTextReader xr = new XmlTextReader(fs);

            while (xr.Read())
            {

                switch (xr.NodeType)
                {
                    case XmlNodeType.None:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Element:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Attribute:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.CDATA:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Entity:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Comment:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Document:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.DocumentType:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.DocumentFragment:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Notation:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Whitespace:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.SignificantWhitespace:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.EndEntity:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.XmlDeclaration:
                        Console.WriteLine(xr.Value);
                        break;
                    default:
                        break;
                }
            }
            xr.Close();
            xr.Dispose();
            fs.Close();
            fs.Dispose();
        }

        private static void XMLcreatewrite()
        {
            XmlWriter xw = XmlWriter.Create("employee.xml");
            xw.WriteStartDocument();

            xw.WriteStartElement("empdata");
            xw.WriteAttributeString("city", "Bangalore");

            xw.WriteElementString("empno", "210");
            xw.WriteElementString("empname", "Babu");
            xw.WriteComment("xmlcreateandwrite");
            xw.WriteEndElement();
            xw.WriteEndDocument();

            xw.Close();
            xw.Dispose();
        }
    }
}
