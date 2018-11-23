using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LoginBUS
    {
        DAO_Login dp = new DAO_Login();
        public bool Login(Account acc)
        {
            return dp.LoginDAO(acc.UserName, acc.Password);
        }

        public int getAllow(string user)
        {
            return dp.getAllowance(user);
        }
    }
}
