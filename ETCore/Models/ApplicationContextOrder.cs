using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCore.Models
{
    public class ApplicationContextOrder : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public ApplicationContextOrder()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=OredTable;Trusted_Connection=True;");
        }
    }
}
