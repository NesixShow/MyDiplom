using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipoDiplom.Models
{
    public class Employeers
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public Users? User { get; set; }

        public string Surname { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string? Patronymic { get; set; } = string.Empty;

        public int GenderId { get; set; }

        public Gender? Genders { get; set; }

        public DateOnly DateBirth { get; set; }

        public int PostId { get; set; }

        public Posts? Post { get; set; }

        public string Email { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; } = string.Empty;

        public DateOnly DateEmployment { get; set; }

        public string Experience { get; set; } = string.Empty;


        public override string ToString()
        {
            return $"{Name} {Patronymic} {Surname}";
        }


    }
}
