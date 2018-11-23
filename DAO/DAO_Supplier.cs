using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_Supplier:DataProvider
    {
        public List<Supplier> GetSupplierDAO()
        {
            string cmdstr = "SELECT * FROM Supplier";
            string id, name, address, web;
            int phone;
            List<Supplier> list = new List<Supplier>();
            connects();
            try
            {
                SqlDataReader sdr = ReaderSQLExecuter(cmdstr);
                while (sdr.Read())
                {
                    id = sdr[0].ToString();
                    name = sdr[1].ToString();
                    address = sdr[2].ToString();
                    phone = int.Parse(sdr[3].ToString());
                    web = sdr[4].ToString();

                    Supplier item = new Supplier(id, name, phone, address, web);
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
        public int add(Supplier Supplier)
        {
            string cmdstr = "INSERT INTO Supplier(MaNCC, TenNCC, DiaChi, SDT, Website) VALUES ('" + Supplier.supId + "','" + Supplier.supName + "','" + Supplier.address + "','" + Supplier.phoneNum + "','" + Supplier.website + "')";
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
            string cmdstr = "DELETE FROM Supplier WHERE MaNCC = '" + value + "'";
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
