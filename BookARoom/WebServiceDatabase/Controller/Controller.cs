using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace WebServiceDatabase.Controller
{
    public class Controller
    {
        
        
        
        List<string> colName = new List<string>();
        List<string[]> resultList;
        
        

        
        public DataTable getEmployeeTables()
        {
            colName.Add("FindEmployee");
            colName.Add("FindEmployeeAbsence");
            colName.Add("FindEmployeeQualifications");
            colName.Add("FindEmployeeRelative");
            colName.Add("FindEmployeePortalSetup");
            colName.Add("FindEmployeeStatisticGroup");

            string[] colID = { "Tabellnamn", "Nr", "Förnamn", "Efternamn", "Initialer", "Jobbtitel" };


            DataTable data = new DataTable();
            
            
            foreach(string col in colID)
            {
                DataColumn dataColumn = data.Columns.Add(col);
            }

            foreach(string colName in colName)
            {
                //data.Rows.Add(dal.GetTables(colName));
            }

            return data;
        }

        public DataTable GetResults (string selectedFunction)
        {
            //resultList = dal.GetTables(selectedFunction);
            string[] colID = resultList.ElementAt(0);
            resultList.RemoveAt(0);


            DataTable data = new DataTable();

            foreach (string col in colID)
            {
                DataColumn dataColumn = data.Columns.Add(col);
            }

            foreach (string[] entry in resultList)
            {
                data.Rows.Add(entry);
            }
        

            return data;
        }


    }

       
    
}
