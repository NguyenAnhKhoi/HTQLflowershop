using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Details
    {
        public string maHD { get; set; }
        public string proID { get; set; }
        public string proName { get; set; }
        public float price { get; set; }
        public int amount { get; set; }
        public float cost { get; set; }

        public Details(string idHD, string idPro, string name, float price, int amount, float cost)
        {
            this.maHD = idHD;
            this.proID = idPro;
            this.proName = name;
            this.price = price;
            this.amount = amount;
            this.cost = cost;
        }
    }
}
