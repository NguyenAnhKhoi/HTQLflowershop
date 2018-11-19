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
    public class PaycheckBUS
    {
        DAO_Paycheckk payDAO = new DAO_Paycheckk();
        public int add(Paycheck paycheck)
        {
            try
            {
                return payDAO.add(paycheck);
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
                return payDAO.del(value);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
