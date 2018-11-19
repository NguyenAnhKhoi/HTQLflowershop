using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_PaycheckkDetails:DataProvider
    {
        public int add(Details details)
        {
            string cmdstr = "INSERT INTO [PayCheck Details](MaHD, MaHH, TenHH, DonGia, SoLuong, ThanhTien) VALUES ('" + details.maHD + "','" + details.proID + "','" + details.proName + "','" + details.price + "','" + details.amount + "','" + details.cost + "')";
            try
            {
                return nonQueryExecuter(cmdstr);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int del(string value)
        {
            string cmdstr = "DELETE FROM [PayCheck Details] WHERE MaHD = '" + value + "'";
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
