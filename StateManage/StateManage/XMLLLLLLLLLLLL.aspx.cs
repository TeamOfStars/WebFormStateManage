using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
namespace StateManage
{
    public partial class XMLLLLLLLLLLLL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("Appdata/kisiler.xml"));
            XmlElement kisi = doc.CreateElement("kisi");
            XmlNode Xad=doc.CreateNode(XmlNodeType.Element,"ad",null);
            Xad.InnerText=tbxAd.Text;
            XmlNode Xsoyad=doc.CreateNode(XmlNodeType.Element,"soyad",null);
            Xsoyad.InnerText=soyad.Text;

            XmlNode Xmail = doc.CreateNode(XmlNodeType.Element, "mail", null);
            Xmail.InnerText = mail.Text;

            XmlNode Xtel = doc.CreateNode(XmlNodeType.Element, "tel", null);
            Xtel.InnerText = tel.Text;

            XmlNode Xcins = doc.CreateNode(XmlNodeType.Element, "cinsiyet", null);
            Xcins.InnerText = ddlCins.SelectedItem.Text;

            kisi.AppendChild(Xad);
            kisi.AppendChild(Xsoyad);
            kisi.AppendChild(Xmail);
            kisi.AppendChild(Xtel);
            kisi.AppendChild(Xcins);
            doc.DocumentElement.AppendChild(kisi);
            doc.Save(Server.MapPath("Appdata/kisiler.xml"));
        }

        protected void btn_txtolustur_Click(object sender, EventArgs e)
        {
            using ( StreamWriter sw = new StreamWriter(Server.MapPath("Appdata/kisiler.txt"),true))
            {
                 XmlTextReader reader = new XmlTextReader(Server.MapPath("Appdata/kisiler.xml"));
            while (reader.Read())
            {
                //sw.Write(reader.Value);//Değerler
                sw.Write(reader.ReadInnerXml());//Komple Xml
            }
            
            }
           
           
        }
    }
}