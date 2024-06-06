using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipoDiplom.Models
{
    public class House
    {
        public int Id { get; set; }
        public byte[]? Image { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int EmployeerId { get; set; }
        public int TypeStructureId { get; set; }
        public int MatTypeId { get; set; }
        public int FloorAmount { get; set; }
        public int FlatAmount { get; set; }


        public Employeers? Employeer { get; set; }
        public TypeStructure? TypeStructure { get; set; }
        public MatType? MatType { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
