using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class receipt
    {
        public string productID { get; set; }
        public string productName { get; set; }
        public float cost { get; set; }
        public string reID { get; set; }

        public receipt (string proID, string name, float cost, string id)
        {
            this.productID = proID;
            this.productName = name;
            this.cost = cost;
            this.reID = id;
        }
    }
}
