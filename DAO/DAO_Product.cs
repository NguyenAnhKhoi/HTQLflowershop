using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Product : DataProvider
    {
        public List<Product> GetProductDAO()
        {
            string cmdstr = "SELECT * FROM Product";
            string proId, supId, name;
            float sell;
            List<Product> list = new List<Product>();
            connects();
            try
            {
                SqlDataReader sdr = ReaderSQLExecuter(cmdstr);
                while (sdr.Read())
                {
                    proId = sdr[0].ToString();
                    name = sdr[1].ToString();
                    sell = float.Parse(sdr[2].ToString());
                    supId = sdr[3].ToString();

                    Product item = new Product(proId, name, sell, supId);
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

        public List<receipt> GetPriceDAO()
        {
            string cmdstr = "SELECT p.MaHH, p.TenHH, p.DonGia, j.MaHD FROM Product p, PayCheckk j";
            float sell;
            string reId, name, proId;
            List<receipt> list = new List<receipt>();
            connects();
            try
            {
                SqlDataReader sdr = ReaderSQLExecuter(cmdstr);
                while (sdr.Read())
                {
                    proId = sdr[0].ToString();
                    name = sdr[1].ToString();
                    sell = float.Parse(sdr[2].ToString());
                    reId = sdr[3].ToString();
                    receipt item = new receipt(proId, name, sell, reId);
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

        public int add(Product product)
        {
            string cmdstr = "INSERT INTO Product(MaHH,TenHH,DonGia,MaNCC) VALUES('" + product.ProductId + "','" + product.ProductName + "','" + product.SellingPrice + "','" + product.SupId + "')";
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
            string cmdstr = "DELETE FROM Product WHERE MaHH = '" + value + "'";
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
