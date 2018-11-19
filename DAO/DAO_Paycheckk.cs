using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_Paycheckk:DataProvider
    {
        public int add(Paycheck paycheck)
        {
            string cmdstr = "INSERT INTO PayCheckk(MaHD,NgayThanhToan,TenKH,ThanhTien) VALUES ('" + paycheck.maHD + "','" + DateTime.Today + "','" + paycheck.cusName + "','" + paycheck.cost + "')";
            try
            {
                return nonQueryExecuter(cmdstr);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
