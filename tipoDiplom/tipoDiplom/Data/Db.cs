using Microsoft.EntityFrameworkCore;
using tipoDiplom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipoDiplom.Data
{
    public class Db:DbContext
    {
        public DbSet<Users> Users { get; set; }

        public DbSet<Posts> Posts { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<MatType> MatType { get; set; }

        public DbSet<TypeStructure> TypeStructures { get; set; }

        public DbSet<Employeers> Employeers { get; set; }

        public DbSet<House> House { get; set; }

        public DbSet<Warehouse> Warehouse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server = (localdb)\MSSqlLocalDB; Database = agroStroy; Trusted_Connection = true; TrustServerCertificate = true;");
        }
    }
}
