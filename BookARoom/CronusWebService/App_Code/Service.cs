using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;


[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    Controller controller = new Controller();

    public Service () {

        
    }

    [WebMethod]
    public DataTable GetEmployeeTables() {
        return controller.getEmployeeTables();
    }

    

}