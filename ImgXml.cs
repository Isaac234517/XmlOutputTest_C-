using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace XmlOutputTest
{
    [Serializable]
    [XmlRootAttribute("Im", Namespace = "", IsNullable = false)]
    public class ImgXml
    {
        [XmlElementAttribute("Data")]
        public byte[] data
        {
            get;
            set;
        }

        [XmlElementAttribute("Name")]
        public string name{
            get;
            set;
        }

        [XmlElementAttribute("Type")]
        public string type
        {
            get;
            set;
        }

        [XmlElementAttribute("Number")]
        public int number
        {
            get;
            set;
        }

        public ImgXml(int number , string name, string type, byte[] data)
        {
            this.number = number;
            this.name = name;
            this.type = type;
            this.data = data;
        }

        public ImgXml()
        {

        }

        public XmlDocument toXmlDocument() {
            using (MemoryStream ms = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ImgXml));
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                XmlTextWriter writer = new XmlTextWriter(ms, Encoding.UTF8);
                serializer.Serialize(writer, this, ns);
                writer.Flush();
                XmlDocument xml = new XmlDocument();
                ms.Position = 0;
                xml.Load(ms);
                writer.Close();
                return xml;
            }

        }

    }
}
