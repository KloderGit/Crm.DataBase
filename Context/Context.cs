using Microsoft.EntityFrameworkCore;
using System;

namespace crm.service.database
{
    public class CrmDataBaseContext : DbContext
    {
        public DbSet<EventLink> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var options = optionsBuilder
                            .UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=password")
                            .Options;
        }
    }
}
