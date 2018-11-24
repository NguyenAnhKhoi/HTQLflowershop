﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        private SqlConnection cn;

        public DataProvider()
        {
            string cnstr = @"Server = 8ZKOCVAMSQYRGRY\SQLEXPRESS ; Database = FlowerShop ; Integrated security = true;";
            cn = new SqlConnection(cnstr);
        }

        public void connects()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public void disconnects()
        {
            try
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public int ScalarSQLExecuter(string sqlcmd)
        {
            SqlCommand cmd = new SqlCommand(sqlcmd, cn);
            cmd.CommandType = System.Data.CommandType.Text;
            connects();
            try
            {
                int number = (int)cmd.ExecuteScalar();
                return number;
            }
            catch (SqlException ex)
            {
                return -1;
            }
            finally
            {
                disconnects();
            }
        }

        public SqlDataReader ReaderSQLExecuter(string sqlcmd)
        {
            SqlCommand cmd = new SqlCommand(sqlcmd, cn);
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                return (cmd.ExecuteReader());
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public int nonQueryExecuter(string sqlcmd)
        {
            SqlCommand cmd = new SqlCommand(sqlcmd, cn);
            cmd.CommandType = System.Data.CommandType.Text;
            connects();
            try
            {
                int rowcount = cmd.ExecuteNonQuery();
                return rowcount;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                disconnects();
            }
        }
    }
}
