﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CronusWebApplication.Model;

namespace CronusWebApplication.DAL
{
    public class Dal
    {
        CRONUSContext db;



        public List<CRONUS_Sverige_AB_Employee> GetAllEmployees()
        {
            using (db = new CRONUSContext())
            {
                return db.CRONUS_Sverige_AB_Employee.ToList();
            }
        }

        public List<CRONUS_Sverige_AB_Employee> GetAllEmployeesAndRelatives()
        {
            using (db = new CRONUSContext())
            {
                var queryResult = db.CRONUS_Sverige_AB_Employee.Join(db.CRONUS_Sverige_AB_Employee_Relative,
                    e => e.No_,
                    er => er.Employee_No_,
                    (e, er) => new { CRONUS_Sverige_AB_Employee = e, CRONUS_Sverige_AB_Employee_Relative = er }).ToList();

                return null;
            }
            
        }

        public List<CRONUSMetadata_Key> GetAllKeys()
        {
            using (db = new CRONUSContext())
            {
                return db.CRONUSMetadata_Key.ToList();
            }
        }

        public List<CRONUSMetadata_Index> GetAllIndexes()
        {
            using (db = new CRONUSContext())
            {
                return db.CRONUSMetadata_Index.Where(i => i.Name.Contains("CRONUS")).ToList();
            }
        }

        public List<CRONUSMetadata_Constraint> GetAllConstraints()
        {
            using (db = new CRONUSContext())
            {
                return db.CRONUSMetadata_Constraint.ToList();
            }
        }

        public List<CRONUSMetadata_Table> GetAllTablesInDB()
        {
            using (db = new CRONUSContext())
            {
                return db.CRONUSMetadata_Table.ToList();
            }
        }


        public List<CRONUSMetadata_Column> GetAllColumnsInEmployees()
        {
            using (db = new CRONUSContext())
            {
                return db.CRONUSMetadata_Column.Where(t => t.Table_Name.Equals("CRONUS Sverige AB$Employee")).ToList();
            }
        }

        /* public List<CronusMetaData_Index> GetMetaData()
         {
             string query = "select name as Namn from sys.indexes where name like '%CRONUS%'";

             using (CRONUSContext db = new CRONUSContext())
             {
                 var queryResult = db.Database.SqlQuery<CRONUSMetaData_Index>(query).ToList();

                 return queryResult;
             }
         }*/

    }
}
 