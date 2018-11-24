using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_Employee:DataProvider
    {
        public List<Employee> GetEmployeeDAO()
        {
            string cmdstr = "SELECT * FROM Employee";
            string id, name, acc, pass;
            int priv;
            List<Employee> list = new List<Employee>();
            connects();
            try
            {
                SqlDataReader sdr = ReaderSQLExecuter(cmdstr);
                while (sdr.Read())
                {
                    id = sdr[0].ToString();
                    name = sdr[1].ToString();
                    acc = sdr[2].ToString();
                    pass = sdr[3].ToString();
                    priv = int.Parse(sdr[4].ToString());

                    Employee item = new Employee(id, name, acc, pass, priv);
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
        public int add(Employee Employee)
        {
            string cmdstr = "INSERT INTO Employee(MaNV,TenNV,TaiKhoan,MatKhau,QuyenSuDung) VALUES ('" + Employee.emId + "','" + Employee.emName + "','" + Employee.accName + "','" + Employee.password + "','" + Employee.privilege + "')";
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
            string cmdstr = "DELETE FROM Employee WHERE MaNV = '" + value + "'";
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
