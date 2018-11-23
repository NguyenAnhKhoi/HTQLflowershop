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
    public class SupplierBUS
    {
        DAO_Supplier supDAO = new DAO_Supplier();
        public List<Supplier> GetDetails()
        {
            try
            {
                return supDAO.GetSupplierDAO();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int add(Supplier supplier)
        {
            try
            {
                return supDAO.add(supplier);
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
                return supDAO.del(value);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
