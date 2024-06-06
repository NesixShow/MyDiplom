using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipoDiplom.Models
{
    public class Warehouse
    {
        public int Id { get; set; }

        public int MatTypeId { get; set; }

        public MatType? MatType { get; set; }

        public string? MatAmount { get; set; } = string.Empty;  

        public double? MatCountBuy { get; set; }

        public double? MatCountSell { get; set; }

        
    }
}
