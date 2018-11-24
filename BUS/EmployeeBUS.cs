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
    public class EmployeeBUS
    {
        DAO_Employee empDAO = new DAO_Employee();
        public List<Employee> GetEmployee()
        {
            try
            {
                return empDAO.GetEmployeeDAO();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int add(Employee Employee)
        {
            try
            {
                return empDAO.add(Employee);
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
                return empDAO.del(value);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
