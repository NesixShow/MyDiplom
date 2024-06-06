using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipoDiplom.Models
{
    public class TypeStructure
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public IEnumerable<House> House { get; set; } = new List<House>();
        public int HouseCount
        {
            get => House.Count();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
