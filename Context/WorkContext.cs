using Microsoft.EntityFrameworkCore;
using System;

namespace crm.service.database
{
    public class CrmDataBaseContext : DbContext
    {
        public DbSet<EventLink> Events { get; set; }

        public CrmDataBaseContext(DbContextOptions<CrmDataBaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}