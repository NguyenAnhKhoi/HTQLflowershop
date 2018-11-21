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
        public List<Paycheck> GetPaycheckDAO()
        {
            string cmdstr = "SELECT * FROM PayCheckk";
            string maHd, cusName, dateSold, empId;
            float cost;
            List<Paycheck> list = new List<Paycheck>();
            connects();
            try
            {
                SqlDataReader sdr = ReaderSQLExecuter(cmdstr);
                while (sdr.Read())
                {
                    maHd = sdr[0].ToString();
                    dateSold = sdr[1].ToString();
                    cusName = sdr[2].ToString();
                    cost = float.Parse(sdr[3].ToString());
                    empId = sdr[4].ToString();

                    Paycheck item = new Paycheck(maHd, cusName, cost, dateSold, empId);
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
        public int add(Paycheck paycheck)
        {
            string cmdstr = "INSERT INTO PayCheckk(MaHD,NgayThanhToan,TenKH,ThanhTien,MaNV) VALUES ('" + paycheck.maHD + "','" + DateTime.Today + "','" + paycheck.cusName + "','" + paycheck.cost + "','E001')";
            try
            {
                return nonQueryExecuter(cmdstr);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int addFull(Paycheck paycheck)
        {
            string cmdstr = "INSERT INTO PayCheckk(MaHD,NgayThanhToan,TenKH,ThanhTien,MaNV) VALUES ('" + paycheck.maHD + "','" + paycheck.dateSold + "','" + paycheck.cusName + "','" + paycheck.cost + "','" + paycheck.empId + "')";
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
            string cmdstr = "DELETE FROM PayCheckk WHERE MaHD = '" + value + "'";
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
