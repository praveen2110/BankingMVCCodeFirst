﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Repository
{
    class DataAccess : IDisposable
    {
        private SqlConnection connection;
        private SqlCommand command;

        public DataAccess()
        {
            string conStr = ConfigurationManager.ConnectionStrings["MVCDbContext"].ToString();
            this.connection = new SqlConnection(conStr);
        }

        public SqlDataReader GetData(string sql) //select 
        {
            this.command = new SqlCommand(sql, this.connection);
            this.connection.Open();
            return this.command.ExecuteReader();
        }

        public int ExecuteSql(string sql) //insert updated and other 
        {
            this.command = new SqlCommand(sql, this.connection);
            this.connection.Open();
            return this.command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.connection.Close();
        }
    }
}
