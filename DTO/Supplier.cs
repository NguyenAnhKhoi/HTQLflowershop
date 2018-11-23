using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Supplier
    {
        public string supId { get; set; }
        public string supName { get; set; }
        public int phoneNum { get; set; }
        public string address { get; set; }
        public string website { get; set; }

        public Supplier(string id, string name, int phone, string address, string web)
        {
            this.supId = id;
            this.supName = name;
            this.phoneNum = phone;
            this.address = address;
            this.website = web;
        }
    }
}
