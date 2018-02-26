using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CronusWebApplication.Model;
using CronusWebApplication.Controller;

namespace CronusWebApplication
{
    /// <summary>
    /// Summary description for CronusWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CronusWebService : WebService
    {
        CronusController controller = new CronusController();



        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee> GetAllEmployees()
        {
            return controller.GetAllEmployees();
        }
/*
        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee> GetAllEmployeesAndRelatives()
        {
            return controller.GetAllEmployeesAndRelatives();
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee> GetAllEmployeeWithAbsence()
        {
            return controller.GetAllEmployeeWithAbsence();
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee> GetAllEmployeeWithAbsenceSick()
        {
            return controller.GetAllEmployeeWithAbsence();
        }*/


        //METADATA
        [WebMethod]
        public List<CRONUSMetadata_Key> GetAllKeys()
        {
            return controller.GetAllKeys();
        }


        [WebMethod]
        public List<CRONUSMetadata_Index> GetAllIndexes()
        {
            return controller.GetAllIndexes();
        }

        [WebMethod]
        public List<CRONUSMetadata_Constraint> GetAllConstraints()
        {
            return controller.GetAllConstraints();

        }

        [WebMethod]
        public List<CRONUSMetadata_Table> GetAllTablesInDB()
        {
            return controller.GetAllTablesInDB();
        }

        [WebMethod]
        public List<CRONUSMetadata_Column> GetAllColumnsInEmployees()
        {
            return controller.GetAllColumnsInEmployees();
        }
    }
}
