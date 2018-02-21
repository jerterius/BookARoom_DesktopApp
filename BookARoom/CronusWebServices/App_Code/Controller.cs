using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Controller
/// </summary>
public class Controller
{
    Dal dal = new Dal();


    public Controller()
    {
       
    }

    List<string> colName = new List<string>();
    List<string[]> resultList;
        
    public DataSet GetTable(string selectedTable)
    {
        return dal.GetTable(selectedTable);
    }

   /* public DataSet getEmployeeTables(string tableName)
    {
        colName.Add("FindEmployee");
        colName.Add("FindEmployeeAbsence");
        colName.Add("FindEmployeeQualifications");
        colName.Add("FindEmployeeRelative");
        colName.Add("FindEmployeePortalSetup");
        colName.Add("FindEmployeeStatisticGroup");

        string[] colID = { "Tabellnamn", "Nr", "Förnamn", "Efternamn", "Initialer", "Jobbtitel" };


        DataTable data = new DataTable();


        foreach (string col in colID)
        {
            DataColumn dataColumn = data.Columns.Add(col);
        }

        foreach (string col in colName)
        {
            data.Rows.Add(dal.GetTables(col));
        }

        DataSet getEmployeeDataSet = new DataSet();
        getEmployeeDataSet.Tables.Add(data);

        return getEmployeeDataSet;
    }

    public DataTable GetResults(string selectedFunction)
    {
        resultList = dal.GetTables(selectedFunction);
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

    public DataSet updateEmployee(string no, string firstName, string lastName, string jobTitle, string adress)
    {
        DataTable employeeDT = new DataTable("Employee");
        
        employeeDT.Columns.Add("No_");
        employeeDT.Columns.Add("First Name");
        employeeDT.Columns.Add("Last Name");
        employeeDT.Columns.Add("Job Title");
        employeeDT.Columns.Add("Adress");
        employeeDT.Rows.Add(no, firstName, lastName, jobTitle, adress);

        DataSet employeeDS = new DataSet("Employee DataSet");
        employeeDS.Tables.Add(employeeDT);



        dal.updateEmployee(employeeDS);

        return employeeDS;

    }

    public DataSet insertEmployee(string no, string firstName, string lastName, string jobTitle, string adress)
    {
        DataTable employeeDT = new DataTable("Employee");

        employeeDT.Columns.Add("No_");
        employeeDT.Columns.Add("First Name");
        employeeDT.Columns.Add("Last Name");
        employeeDT.Columns.Add("Job Title");
        employeeDT.Columns.Add("Adress");
        employeeDT.Rows.Add(no, firstName, lastName, jobTitle, adress);

        DataSet employeeDS = new DataSet("Employee DataSet");
        employeeDS.Tables.Add(employeeDT);

        return dal.insertEmployee(employeeDS);
    }*/


}
