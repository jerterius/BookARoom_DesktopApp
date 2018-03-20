using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CronusWebApplication.Model;
using CronusWebApplication.DAL;
using System.Data.Entity.Validation;
using System.Data.SqlClient;

namespace CronusWebApplication.Controller
{
    public class CronusController : ApiController
    {
        Dal dal = new Dal();

        
        public CRONUS_Sverige_AB_Partner AddPartner(CRONUS_Sverige_AB_Partner newPartner)
        {
            try
            {
                return dal.AddPartner(newPartner);
            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }
            catch (SqlException e)
            {
                throw e;
            }

            catch (Exception e)
            {
                throw e;
            }
            
  
        }

       
        public CRONUS_Sverige_AB_Partner UpdatePartner(CRONUS_Sverige_AB_Partner oldPartner, CRONUS_Sverige_AB_Partner newPartner)
        {
            try
            {
                dal.RemovePartner(oldPartner);
                return dal.AddPartner(newPartner);
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        
        public CRONUS_Sverige_AB_Partner RemovePartner(CRONUS_Sverige_AB_Partner partner)
        {
            try
            {
                return dal.RemovePartner(partner);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<CRONUS_Sverige_AB_Partner> GetAllPartners()
        {
            return dal.GetAllPartners();
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

        public List<CRONUSMetadata_EmployeeRelated> GetEmployeeMetaDataAndRelated()
        {
            return dal.GetEmployeesMetadataAndRelated();
        }

        public List<CRONUS_Employee_Top5_Absence> GetTop5EmployeesAbsent()
        {
            return dal.GetTop5EmployeesAbsent();
        }

        public List<CRONUS_Employees_And_Relatives> GetEmployeesAndRelatives()
        {
            return dal.GetEmployeesAndRelatives();
        }

        public List<CRONUS_Employees_Sick_2004> GetEmployeesSick2004()
        {
            return dal.GetEmployeesSick2004();
        }
    }
}
