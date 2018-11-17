using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Account
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        /// Constructor
        public Account(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
    }
}
