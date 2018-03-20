using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CronusWebApplication.Model;
using CronusWebApplication.Controller;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Web.Services.Protocols;
using System.Xml;

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
        public CRONUS_Sverige_AB_Partner AddPartner(CRONUS_Sverige_AB_Partner newPartner)
        {
            try
            {
                return controller.AddPartner(newPartner);
            }
            catch (SoapException e)
            {
                throw e;
            }

            catch (SqlException e)
            {
                throw e;
            }

            catch (DbEntityValidationException e)
            {
                throw new SoapException();
            }

            catch (Exception e)
            {
                throw e;
            }
   
        }

        [WebMethod]
        public CRONUS_Sverige_AB_Partner UpdatePartner(CRONUS_Sverige_AB_Partner oldPartner, CRONUS_Sverige_AB_Partner newPartner)
        {
            try
            {
                return controller.UpdatePartner(oldPartner, newPartner);
            } catch (Exception e)
            {
                throw e;
            }
        }

        [WebMethod]
        public CRONUS_Sverige_AB_Partner RemovePartner(CRONUS_Sverige_AB_Partner partner)
        {
            return controller.RemovePartner(partner);
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Partner> GetAllPartners()
        {
            return controller.GetAllPartners();
        }

        [WebMethod]
        public List<CRONUSMetadata_EmployeeRelated> GetEmployeeMetaDataAndRelated()
        {
            return controller.GetEmployeeMetaDataAndRelated();
        }

        [WebMethod]
        public List<CRONUS_Employee_Top5_Absence> GetTop5EmployeesAbsent()
        {
            return controller.GetTop5EmployeesAbsent();
        }

        [WebMethod]
        public List<CRONUS_Employees_And_Relatives> GetEmployeesAndRelatives()
        {
            return controller.GetEmployeesAndRelatives();
        }

        [WebMethod]
        public List<CRONUS_Employees_Sick_2004> GetEmployeesSick2004()
        {
            return controller.GetEmployeesSick2004();
        }

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
