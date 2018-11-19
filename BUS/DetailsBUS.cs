using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class DetailsBUS
    {
        DAO_PaycheckkDetails detDAO = new DAO_PaycheckkDetails();
        public int add(Details details)
        {
            try
            {
                return detDAO.add(details);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int del(string value)
        {
            try
            {
                return detDAO.del(value);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
