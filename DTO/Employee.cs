using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        public string emId { get; set; }
        public string emName { get; set; }
        public string accName { get; set; }
        public string password { get; set; }

        private Employee(string id, string name, string acc, string pass)
        {
            this.emId = id;
            this.emName = name;
            this.accName = acc;
            this.password = pass;
        }
    }
}
