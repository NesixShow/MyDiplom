using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipoDiplom.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string Login { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public int RoleId { get; set; }

        public Role? Roles { get; set; }

        public override string ToString()
        {
            return Login;
        }
    }
}
