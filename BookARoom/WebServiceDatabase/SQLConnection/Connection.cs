﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace WebServiceDatabase.SQLConnection
{
    public class Connection
    {

        SqlDataAdapter da = new SqlDataAdapter();

        public SqlDataAdapter Da { get => da; set => da = value; }

        public SqlConnection OpenConnect()
         { 
            string dbAdress = "Data Source=DESKTOP-5OKAJKP;Initial Catalog=Demo Database NAV(5 - 0);Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            SqlConnection con = new SqlConnection(dbAdress);
            return con;
         } 

        public void CloseConnect(SqlConnection con)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Dispose();
        }

        public SqlCommand QueryStatement(string query)
        {
            SqlCommand cmd = new SqlCommand(query, OpenConnect());
            cmd.CommandType = CommandType.Text;
            Da.SelectCommand = cmd;

            return cmd;
        } 
       
        
    }
}