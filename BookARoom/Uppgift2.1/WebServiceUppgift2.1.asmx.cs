using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Uppgift2._1
{
    /// <summary>
    /// Summary description for WebServiceUppgift2__1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceUppgift2__1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetFile()
        {
            StreamReader sr = File.OpenText("C:\\Users\\Nina\\Documents\\Programkonstruktion\\Text.txt");

            string line = sr.ReadToEnd();
            return line;
        }
    }
}
