using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using WebServiceDatabase.DAL;

namespace WebServiceDatabase.Controller
{
    public class Controller
    {
        DataAccesLayer dal = new DataAccesLayer();

        public DataTable getEmployeeTables(string selectedFunction)
        {
            DataTable data = new DataTable();

            return data;
        }
    }
}
