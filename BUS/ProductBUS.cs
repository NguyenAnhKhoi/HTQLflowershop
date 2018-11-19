using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public class ProductBUS
    {
        DAO_Product proDAO = new DAO_Product();

        public List<Product> getProduct()
        {
            try
            {
                return proDAO.GetProductDAO();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<double> getPrice()
        {
            try
            {
                return proDAO.GetPriceDAO();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int add(Product product)
        {
            try
            {
                return proDAO.add(product);
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
                return proDAO.del(value);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
