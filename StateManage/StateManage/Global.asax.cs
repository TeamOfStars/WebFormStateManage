using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;
using System.Xml;
namespace StateManage
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application.Add("kullaniciSayisi", 0);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["kullaniciSayisi"] = Session.Count + 1;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }
         
        protected void Application_Error(object sender, EventArgs e)
        {
           //StreamWriter st = new StreamWriter(Server.MapPath("Appdata/log.txt"),true);
           // st.WriteLine(DateTime.Now.ToLongDateString()+":"+Server.MachineName.ToString()+":"+ Server.GetLastError().Message.ToString());
           // st.Close();

            //XmlDocument doc = new XmlDocument();
            //doc.Load(Server.MapPath("Appdata//log.xml"));

            //XmlElement log = doc.CreateElement("log");

            //XmlNode errorMessage = doc.CreateNode(XmlNodeType.Element, "errorMessage", null);
            //errorMessage.InnerText = Server.GetLastError().Message.ToString();

            //XmlNode date = doc.CreateNode(XmlNodeType.Element, "date", null);
            //date.InnerText = DateTime.Now.ToLongDateString();


            //log.AppendChild(errorMessage);
            //log.AppendChild(date);


            //doc.DocumentElement.AppendChild(log);

            //doc.Save(Server.MapPath("Appdata//log.xml"));


            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("Appdata/hatalar.xml"));

            XmlElement log = doc.CreateElement("errorlog");
            XmlNode errorMessage = doc.CreateNode(XmlNodeType.Element,"errormessage",null);
            errorMessage.InnerText=Server.GetLastError().Message;
            XmlNode date = doc.CreateNode(XmlNodeType.Element,"date",null);
            date.InnerText=DateTime.Now.ToLongDateString();
            XmlNode IP = doc.CreateNode(XmlNodeType.Element,"IP",null);
            IP.InnerText=Request.ServerVariables["remote_ADDR"];

            log.AppendChild(errorMessage);
            log.AppendChild(date);
            log.AppendChild(IP);

            doc.DocumentElement.AppendChild(log);
            doc.Save(Server.MapPath("Appdata/hatalar.xml"));






        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}