using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BookARoom.Models;


namespace BookARoomServiceApp
{
    /// <summary>
    /// Summary description for BookARoomWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BookARoomWebService : System.Web.Services.WebService
    {
        ControllerBookARoomClient controller = new ControllerBookARoomClient();

        [WebMethod]
        public List<Booking> GetEntities(string selectedTable)
        {
            return controller.GetEntities(selectedTable).Cast<Booking>().ToList();
        }
    }
}
