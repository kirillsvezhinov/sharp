using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore;

namespace шарп_проект
{
    internal class DbService : DbContext
    {
        public DbSet<Organization> Organization { get; set; }
        public DbSet<Organization_Type> Organization_Type { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Municipality> Municipality { get; set; }
        public DbSet<Organization_Sign> Organization_Sign { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=organisations;Username=postgres;Password=root");

    }
}
