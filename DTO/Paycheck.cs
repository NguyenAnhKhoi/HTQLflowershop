using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Paycheck
    {
        public string maHD { get; set; }
        public string cusName { get; set; }
        public float cost { get; set; }

        public Paycheck(string id, string name, float cost)
        {
            this.maHD = id;
            this.cusName = name;
            this.cost = cost;
        }
    }
}
