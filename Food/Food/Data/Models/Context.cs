using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Data.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0F3TA7A; database=CoreProjeFood; Integrated Security=true");
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<FoodContent> FoodContent { get; set; }
    }
}
