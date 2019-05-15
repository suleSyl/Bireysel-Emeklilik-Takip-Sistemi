using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WP_Project
{
    public static class OdemeSekilleriXml
    {
        private static string klasorAdres = @"C:\\OdemeSekilleri";
        private static string xmlAdres = Path.Combine(klasorAdres, "OdemeSekli.xml");

        public static void klasorOlustur()
        {
            if (!Directory.Exists(klasorAdres))
                Directory.CreateDirectory(klasorAdres);
        }

        public static void xmlDosyasıOlustur()
        {
            klasorOlustur();
            if (!File.Exists(xmlAdres))
            {
                var file = File.Create(xmlAdres);
                file.Close();
            }
        }

        public static void odemeSekilleriniXmleYaz()
        {
            OdemeSekliSema odemeSekliSema = new OdemeSekliSema();
            List<OdemeSekliSemaOdemeSekli> menuItemList = new List<OdemeSekliSemaOdemeSekli>
            {
                new OdemeSekliSemaOdemeSekli() { OdemeSekliAdi = "Kredi Kartı" },
                new OdemeSekliSemaOdemeSekli() { OdemeSekliAdi = "Otomatik Ödeme" },
                new OdemeSekliSemaOdemeSekli() { OdemeSekliAdi = "Havale" }
            };
            odemeSekliSema.OdemeSekli = menuItemList.ToArray();
            XmlSerializer xs = new XmlSerializer(typeof(OdemeSekliSema));
            string xml = "";
            using (StringWriter stringWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
                {
                    xs.Serialize(xmlWriter, odemeSekliSema);
                    xml = stringWriter.ToString();
                }
            }
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            xmlDoc.Save(xmlAdres);
        }

        public static List<String> odemeSekilleriniOku()
        {
            if (File.Exists(xmlAdres))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlAdres);
                XmlNode menuNode = xmlDoc.ChildNodes[1];
                List<String> odemeSekilleri = new List<String>();
                foreach (XmlNode item in menuNode)
                {
                    odemeSekilleri.Add(item["OdemeSekliAdi"].InnerText.Trim());              
                }
                return odemeSekilleri;
            }
            return new List<String>();
        }




    }
}
