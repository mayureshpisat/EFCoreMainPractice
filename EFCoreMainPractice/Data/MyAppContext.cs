using EFCoreMainPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMainPractice.Data
{
    public class MyAppContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-53KKGG8\\MSSQLSERVER02;Initial Catalog=games_ef_db;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
