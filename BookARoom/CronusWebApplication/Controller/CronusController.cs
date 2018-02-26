using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CronusWebApplication.Model;
using CronusWebApplication.DAL;

namespace CronusWebApplication.Controller
{
    public class CronusController : ApiController
    {
        Dal dal = new Dal();


        public List<CRONUS_Sverige_AB_Employee> GetAllEmployees()
        {
            return dal.GetAllEmployees();
        }

        public List<CRONUS_Sverige_AB_Employee> GetAllEmployeesAndRelatives()
        {
            return dal.GetAllEmployees();
        }

        public List<CRONUSMetadata_Key> GetAllKeys()
        {
            return dal.GetAllKeys();
        }

        public List<CRONUSMetadata_Index> GetAllIndexes()
        {
            return dal.GetAllIndexes();
        }

        public List<CRONUSMetadata_Constraint> GetAllConstraints()
        {
            return dal.GetAllConstraints();
        }

        public List<CRONUSMetadata_Table> GetAllTablesInDB()
        {
            return dal.GetAllTablesInDB();
        }

        public List<CRONUSMetadata_Column> GetAllColumnsInEmployees()
        {
            return dal.GetAllColumnsInEmployees();
        }
    }
}
