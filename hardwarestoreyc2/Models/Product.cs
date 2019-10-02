using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace hardwarestoreyc2.Models
{
    public class Product
    {
        public int ID { get; set; }
        
        public string ProductName { get; set; }
        public DateTime ProductDate { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
