using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CronusWebApplication
{
    public class Dal
    {

        public List<CronusMetaData_Index> GetMetaData()
        {
            string query = "select name as Namn from sys.indexes where name like '%CRONUS%'";

            using (CronusContext db = new CronusContext())
            {
                var queryResult = db.Database.SqlQuery<CronusMetaData_Index>(query).ToList();

                return queryResult;
            }
        }

        public List<CRONUS_Sverige_AB_Employee> GetEmployees()
        {

            using (CronusContext db = new CronusContext())
            {
                //var queryResult = db.CRONUS_Sverige_AB_Employee.Select(e => e.).ToList();

                //return queryResult;
                return null;
            }
        }
    }
}