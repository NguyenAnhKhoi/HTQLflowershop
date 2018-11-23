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
        public List<Details> GetDetailDAO()
        {
            string cmdstr = "SELECT * FROM [PayCheck Details]";
            string maHd, proId, proName;
            float price, cost;
            int amount;
            List<Details> list = new List<Details>();
            connects();
            try
            {
                SqlDataReader sdr = ReaderSQLExecuter(cmdstr);
                while (sdr.Read())
                {
                    maHd = sdr[0].ToString();
                    proId = sdr[1].ToString();
                    proName = sdr[2].ToString();
                    price = float.Parse(sdr[3].ToString());
                    amount = int.Parse(sdr[4].ToString());
                    cost = float.Parse(sdr[5].ToString());

                    Details item = new Details(maHd, proId, proName, price, amount, cost);
                    list.Add(item);
                }
                sdr.Close();
                return list;
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
            string cmdstr = "DELETE FROM [PayCheck Details] WHERE MaHH = '" + value + "'";
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
