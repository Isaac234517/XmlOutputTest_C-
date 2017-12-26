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
using System.IO;


namespace XmlOutputTest
{
    public partial class Form1 : Form
    {
        private string path = "./samplePicture.jpg";
        public Form1()
        {
            InitializeComponent();
        }


        private void xmlNodeBtn_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(path);
            XmlDocument xml = new XmlDocument();
            XmlDeclaration declaration = xml.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = xml.DocumentElement;
            xml.InsertBefore(declaration, root);
            XmlElement imageNode = xml.CreateElement(string.Empty, "Im", string.Empty);
            xml.AppendChild(imageNode);
            XmlElement filenameElement = xml.CreateElement(string.Empty, "Name", string.Empty);
            filenameElement.InnerText = Path.GetFileNameWithoutExtension(this.path);
            imageNode.AppendChild(filenameElement);

            XmlElement numberElement = xml.CreateElement(string.Empty, "Number", string.Empty);
            numberElement.InnerText = "1";
            imageNode.AppendChild(numberElement);

            XmlElement typeElement = xml.CreateElement(string.Empty, "Type", string.Empty);
            typeElement.InnerText = Path.GetExtension(this.path).Substring(1);
            imageNode.AppendChild(typeElement);

            using (MemoryStream ms = new MemoryStream()) {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] dataBytes = ms.ToArray();
                XmlElement dataElement = xml.CreateElement(string.Empty, "Data", string.Empty);
                dataElement.InnerText = System.Convert.ToBase64String(dataBytes);
                imageNode.AppendChild(dataElement);
            }

            xml.Save(Path.GetDirectoryName(Application.ExecutablePath) + "/test.xml");
        }

        private void xmlWriterBtn_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(path);
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                using (FileStream fm = new FileStream(Path.GetDirectoryName(Application.ExecutablePath) + "/test.xml", FileMode.Create, FileAccess.ReadWrite))
                {
                    XmlTextWriter writer = new XmlTextWriter(fm, Encoding.UTF8);
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Im");
                    writer.WriteElementString("Name", Path.GetFileNameWithoutExtension(this.path));
                    writer.WriteElementString("Number", "1");
                    writer.WriteElementString("Type", Path.GetExtension(this.path).Substring(1));
                    writer.WriteStartElement("Data");
                    writer.WriteBase64(ms.ToArray(), 0, ms.ToArray().Length);
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
            }
        }

        private void xmlSerializerBtn_Click(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream()) {
                Bitmap image = new Bitmap(this.path);
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ImgXml imgXml = new ImgXml(1, Path.GetFileNameWithoutExtension(this.path), Path.GetExtension(this.path).Substring(1), ms.ToArray());
                XmlDocument xml = imgXml.toXmlDocument();
                xml.Save(Path.GetDirectoryName(Application.ExecutablePath) + "/test.xml");
            }
        }
    }
}
