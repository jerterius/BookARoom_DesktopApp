using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Dal
/// </summary>
public class Dal
{
    public Dal()
    { }
    
    private string selectedFunctions;
    private string query = null;

    SqlDataReader reader;
    SqlDataAdapter da = new SqlDataAdapter();
    
    public DataSet GetTable(string selectedTable)
    {
        SqlConnection sqlConnection1 = new SqlConnection();
        // Now Pass a Connection String To the Connection
        sqlConnection1.ConnectionString = "Data Source = DESKTOP-08VEOGS; Initial Catalog = Demo Database NAV (5-0); User ID = admin; Password = admin";
        // Now the Select statement you want to run

        switch (selectedTable)
        {
            case "All Employees":
                // query = "select 'Employee' as Tabellnamn, No_, [First Name], [Last Name], Initials, [Job Title] from  dbo.[CRONUS Sverige AB$Employee]";
                query = "select [Job Title], [First Name], [Last Name], [Address] from  dbo.[CRONUS Sverige AB$Employee]";
                break;
            case "Employee Absence":
                query = "select 'Employee Absence' as Tabellnamn, [Entry No_], [Employee No_], [From Date], [To Date], [Cause of Absence Code] from dbo.[CRONUS Sverige AB$Employee Absence]";

                break;
            case "FindEmployeeQualifications":
                query = "select 'Employee Qualification' as Tabellnamn, [Employee No_], [Line No_], [Qualification Code], Type, Description from dbo.[CRONUS Sverige AB$Employee Qualification]";

                break;
            case "FindEmployeeRelative":
                query = "select 'Employee Relative' as Tabellnamn, [Employee No_], [Line No_], [Relative Code], [First Name], [Last Name] from dbo.[CRONUS Sverige AB$Employee Relative]";

                break;
            case "FindEmployeePortalSetup":
                query = "select 'Employee Portal Setup'as Tabellnamn, [Search Limit], [Temp_ Key Index], [Temp_ Table No_], [Temp_ Key String], [Temp_ Option Value]\r\n"
                        + "	from dbo.[CRONUS Sverige AB$Employee Portal Setup]";

                break;
            case "FindEmployeeStatisticGroup":
                query = "select 'Employee Statistics Group' as Tabellnamn, *, ' ', ' ' " // Lade till extra kolumner som
                                                                                         // ' '.
                    + "	from  dbo.[CRONUS Sverige AB$Employee Statistics Group]";
                break;

            case "Employees And Relatives":
                query = "select[CRONUS Sverige AB$Employee].[First Name], [CRONUS Sverige AB$Employee].[Last Name], [CRONUS Sverige AB$Employee].[Job Title], [CRONUS Sverige AB$Employee Relative].[First Name] Relative, [CRONUS Sverige AB$Relative].Description " +
                    "from(([CRONUS Sverige AB$Employee Relative]" +
                    "inner join [CRONUS Sverige AB$Employee] on[CRONUS Sverige AB$Employee Relative].[Employee No_]= [CRONUS Sverige AB$Employee].No_)" +
                    "inner join[CRONUS Sverige AB$Relative] on[CRONUS Sverige AB$Employee Relative].[Relative Code] = [CRONUS Sverige AB$Relative].Code)";
                break;

            case "Employee Absence (2004)":
                query = "select [CRONUS Sverige AB$Employee].[First Name],  [CRONUS Sverige AB$Employee].[Job Title], [From Date], [To Date], [Cause of Absence Code] " +
                    "from dbo.[CRONUS Sverige AB$Employee Absence] " +
                    "inner join [CRONUS Sverige AB$Employee] on [CRONUS Sverige AB$Employee Absence].[Employee No_] = [CRONUS Sverige AB$Employee].No_ " +
                    "where [Cause of Absence Code] = 'SJUK' " +
                    "and[From Date] >= '2004-01-01 00:00:00' " +
                    "and[From Date] < '2005-01-01 00:00:00'";
                break;

            case "Employees With Most Absence":
                query = " select top 5 [CRONUS Sverige AB$Employee].[First Name]" +
                    "from dbo.[CRONUS Sverige AB$Employee Absence]" +
                    "inner join [CRONUS Sverige AB$Employee] on [CRONUS Sverige AB$Employee Absence].[Employee No_] = [CRONUS Sverige AB$Employee].No_" +
                    "group by [CRONUS Sverige AB$Employee].[First Name]" +
                    "order by COUNT(*) desc";
                break;

            case "Samtliga nycklar":

                query = "select distinct constraint_name as [Samtliga nycklar] from INFORMATION_SCHEMA.KEY_COLUMN_USAGE";

                break;
            case "Samtliga index":

                query = "select object_id as [Objekt id],name as Namn, index_id as [Index id], type as Typ, type_desc as Typbeskrivning from sys.indexes where name like '%CRONUS%'";

                break;
            case "Samtliga tabellbegränsningar":

                query = "select constraint_name Begränsningsnamn, table_name as Tabellnamn, constraint_type as Begränsningstyp from INFORMATION_SCHEMA.TABLE_CONSTRAINTS";

                break;
            case "Samtliga tabeller":

                query = "select name as [Samtliga tabeller] from sys.tables order by name";

                // alt 2
                // "select * from INFORMATION_SCHEMA.TABLES";

                break;
            case "Samtliga kolumner från tabellen Employee":

                query = "select column_name as Kolumnnamn, table_name as Tabellnamn from INFORMATION_SCHEMA.COLUMNS where table_name = 'CRONUS Sverige AB$Employee'";

                // alt 2
                // query = "select c.name from sys.columns c inner join sys.tables t
                // on c.object_id = t.object_id and t.name = 'CRONUS Sverige
                // AB$Employee';";

                break;
            case "Tabell med flest rader":

                query = "select top 1 tablename as Tabellnamn from (select object_name(object_id)tablename, "
                        + "st.row_count as antal from sys.dm_db_partition_stats st where index_id < 2) "
                        + "x where tablename like 'CRONUS%' group by tablename, antal order by antal desc;";

                break;
        }




        // Create an Adapter
        SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection1);
        // Create a New DataSet
        DataSet ds = new DataSet();
        // Fill The DataSet With the Contents of the Stock Table
        da.Fill(ds, "Employees");
        // Now Return ds which is a DataSet
        return (ds);
    }


    /*public List<string[]> GetTables(string selectedFunction)
    {
        List<string[]> resultList = new List<string[]>();
        
        selectedFunctions = selectedFunction;

        switch (selectedFunctions)
        {
            case "FindEmployee":
                query = "select 'Employee' as Tabellnamn, No_, [First Name], [Last Name], Initials, [Job Title] from  dbo.[CRONUS Sverige AB$Employee]";

                break;
            case "FindEmployeeAbsence":
                query = "select 'Employee Absence' as Tabellnamn, [Entry No_], [Employee No_], [From Date], [To Date], [Cause of Absence Code] from dbo.[CRONUS Sverige AB$Employee Absence]";

                break;
            case "FindEmployeeQualifications":
                query = "select 'Employee Qualification' as Tabellnamn, [Employee No_], [Line No_], [Qualification Code], Type, Description from dbo.[CRONUS Sverige AB$Employee Qualification]";

                break;
            case "FindEmployeeRelative":
                query = "select 'Employee Relative' as Tabellnamn, [Employee No_], [Line No_], [Relative Code], [First Name], [Last Name] from dbo.[CRONUS Sverige AB$Employee Relative]";

                break;
            case "FindEmployeePortalSetup":
                query = "select 'Employee Portal Setup'as Tabellnamn, [Search Limit], [Temp_ Key Index], [Temp_ Table No_], [Temp_ Key String], [Temp_ Option Value]\r\n"
                        + "	from dbo.[CRONUS Sverige AB$Employee Portal Setup]";

                break;
            case "FindEmployeeStatisticGroup":
                query = "select 'Employee Statistics Group' as Tabellnamn, *, ' ', ' ' " // Lade till extra kolumner som
                                                                                         // ' '.
                    + "	from  dbo.[CRONUS Sverige AB$Employee Statistics Group]";
                break;

            case "FindEmployeeAndRelatives":
                query = "select[CRONUS Sverige AB$Employee].[First Name], [CRONUS Sverige AB$Employee].[Last Name], [CRONUS Sverige AB$Employee].[Job Title], [CRONUS Sverige AB$Employee Relative].[First Name] Relative, [CRONUS Sverige AB$Relative].Description " +
                    "from(([CRONUS Sverige AB$Employee Relative]" +
                    "inner join [CRONUS Sverige AB$Employee] on[CRONUS Sverige AB$Employee Relative].[Employee No_]= [CRONUS Sverige AB$Employee].No_)" +
                    "inner join[CRONUS Sverige AB$Relative] on[CRONUS Sverige AB$Employee Relative].[Relative Code] = [CRONUS Sverige AB$Relative].Code)";
                break;

            case "FindEmployeeAbsence2004":
                query = "select [CRONUS Sverige AB$Employee].[First Name],  [CRONUS Sverige AB$Employee].[Job Title], [From Date], [To Date], [Cause of Absence Code] " +
                    "from dbo.[CRONUS Sverige AB$Employee Absence]" +
                    "inner join [CRONUS Sverige AB$Employee] on [CRONUS Sverige AB$Employee Absence].[Employee No_] = [CRONUS Sverige AB$Employee].No_" +
                    "where [Cause of Absence Code] = 'SJUK'" +
                    "and[From Date] >= '2004-01-01 00:00:00'" +
                    "and[From Date] < '2005-01-01 00:00:00'";
                break;

            case "EmployeeWithMostAbsence":
                query = " select top 5 [CRONUS Sverige AB$Employee].[First Name]" +
                    "from dbo.[CRONUS Sverige AB$Employee Absence]" +
                    "inner join [CRONUS Sverige AB$Employee] on [CRONUS Sverige AB$Employee Absence].[Employee No_] = [CRONUS Sverige AB$Employee].No_" +
                    "group by [CRONUS Sverige AB$Employee].[First Name]" +
                    "order by COUNT(*) desc";
                break;

            case "Samtliga nycklar":

                query = "select distinct constraint_name as [Samtliga nycklar] from INFORMATION_SCHEMA.KEY_COLUMN_USAGE";

                break;
            case "Samtliga index":

                query = "select object_id as [Objekt id],name as Namn, index_id as [Index id], type as Typ, type_desc as Typbeskrivning from sys.indexes where name like '%CRONUS%'";

                break;
            case "Samtliga tabellbegränsningar":

                query = "select constraint_name Begränsningsnamn, table_name as Tabellnamn, constraint_type as Begränsningstyp from INFORMATION_SCHEMA.TABLE_CONSTRAINTS";

                break;
            case "Samtliga tabeller":

                query = "select name as [Samtliga tabeller] from sys.tables order by name";

                // alt 2
                // "select * from INFORMATION_SCHEMA.TABLES";

                break;
            case "Samtliga kolumner från tabellen Employee":

                query = "select column_name as Kolumnnamn, table_name as Tabellnamn from INFORMATION_SCHEMA.COLUMNS where table_name = 'CRONUS Sverige AB$Employee'";

                // alt 2
                // query = "select c.name from sys.columns c inner join sys.tables t
                // on c.object_id = t.object_id and t.name = 'CRONUS Sverige
                // AB$Employee';";

                break;
            case "Tabell med flest rader":

                query = "select top 1 tablename as Tabellnamn from (select object_name(object_id)tablename, "
                        + "st.row_count as antal from sys.dm_db_partition_stats st where index_id < 2) "
                        + "x where tablename like 'CRONUS%' group by tablename, antal order by antal desc;";

                break;
        }
        /*con.OpenConnect();

        reader = con.QueryStatement(query).ExecuteReader();
        var columns = new List<string>();

        for (int i = 0; i < reader.FieldCount; i++)
        {
            columns.Add(reader.GetName(i));
        }

        resultList.Add(columns.ToArray());

        con.CloseConnect(con.OpenConnect());
        return resultList;

    }


    public DataSet updateEmployee(DataSet employeeDS)
    {
        con.OpenConnect(); 

        da.InsertCommand = new SqlCommand("insert into dbo.[CRONUS Sverige AB$Employee](No_, [First Name], [Last Name], [Job Title], Adress, '', '', '', '', '', '', '', '', '', '','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')" +
            " values(@No_, @[First Name], @[Last Name], @[Job Title], @Adress)");
        da.InsertCommand.Parameters.Add("@No_", SqlDbType.NChar, 20, "No_");
        da.InsertCommand.Parameters.Add("@[First Name]", SqlDbType.NChar, 30, "[First Name]");
        da.InsertCommand.Parameters.Add("@[Last Name]", SqlDbType.NChar, 30, "[Last Name]");
        da.InsertCommand.Parameters.Add("@[Job Title]", SqlDbType.NChar, 30, "[Job Title]");
        da.InsertCommand.Parameters.Add("@Adress", SqlDbType.NChar, 50, "Adress");

        da.UpdateCommand = new SqlCommand("update dbo.[CRONUS Sverige AB$Employee set No_ = @No_" + "[First Name] = @[First Name]" + "@[Last Name] = [Last Name]" + "@[Job Title] = [Job Title]" + "@Adress = [Adress] where No_ = @oldNo_");
        da.UpdateCommand.Parameters.Add("@No_", SqlDbType.NChar, 20, "No_");
        da.UpdateCommand.Parameters.Add("@[First Name", SqlDbType.NChar, 30, "[First Name]");
        da.UpdateCommand.Parameters.Add("@[Last Name]", SqlDbType.NChar, 30, "[Last Name]");
        da.UpdateCommand.Parameters.Add("@[Job Title]", SqlDbType.NChar, 30, "[Job Title]");
        da.UpdateCommand.Parameters.Add("@Adress", SqlDbType.NChar, 50, "Adress");

        SqlParameter parameter = da.UpdateCommand.Parameters.Add("@oldNo_", SqlDbType.NChar, 20, "No_");
        parameter.SourceVersion = DataRowVersion.Original;

        da.DeleteCommand = new SqlCommand("delete [CRONUS Sverige AB$Employee] where No_ = @No_", con.OpenConnect());

        parameter = da.DeleteCommand.Parameters.Add("@No_", SqlDbType.NChar, 20, "No_");

        parameter.SourceVersion = DataRowVersion.Original;
        da.Update(employeeDS, "[CRONUS Sverige AB$Employee]");

        return employeeDS;
    }

    public void DeleteEmployee(string no)
    {
        con.OpenConnect();

        query = "delete from [CRONUS Sverige AB$Employee] where No_ = " + no;
        con.QueryStatement(query).ExecuteNonQuery();
        con.CloseConnect(con.OpenConnect());
    }

    public DataSet insertEmployee(DataSet employeeDS)
    {
       
        query = "insert into dbo.[CRONUS Sverige AB$Employee](No_, [First Name], [Last Name], [Job Title], Adress, '', '', '', '', '', '', '', '', '', '','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')" +
            " values(@No_, @[First Name], @[Last Name], @[Job Title], @Adress)";
        SqlCommand cmd = new SqlCommand(query, con.OpenConnect());
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@No_", SqlDbType.NChar, 20, "No_");
        cmd.Parameters.Add("@[First Name", SqlDbType.NChar, 30, "[First Name]");
        cmd.Parameters.Add("@[Last Name]", SqlDbType.NChar, 30, "[Last Name]");
        cmd.Parameters.Add("@[Job Title]", SqlDbType.NChar, 30, "[Job Title]");
        cmd.Parameters.Add("@Adress", SqlDbType.NChar, 50, "Adress");
        cmd.ExecuteNonQuery();

        return employeeDS;



    }*/




}
