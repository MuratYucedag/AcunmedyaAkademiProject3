using AcunmedyaAkademiProject3.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunmedyaAkademiProject3.Context
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R7AR1ND;initial catalog=AcunmedyaDb3;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
//trustservercertificate=true;