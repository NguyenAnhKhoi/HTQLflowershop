using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Login : DataProvider
    {
        public bool LoginDAO(string user, string pass)
        {
            string cmdstr = "SELECT COUNT(TenNV) FROM Employee WHERE TaiKhoan = N'" + user + "' AND MatKhau = N'" + pass + "'";
            int output;
            try
            {
                output = ScalarSQLExecuter(cmdstr);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            if (output > 0)
                return true;
            else
                return false;
        }

    }
}
