using Microsoft.EntityFrameworkCore;

namespace crm.service.database
{
    public class CrmDataBaseContext : DbContext
    {
        public DbSet<EventLink> Events { get; set; }

        public CrmDataBaseContext()
        {
        }

        public CrmDataBaseContext(DbContextOptions<CrmDataBaseContext> options) : base(options)
        {
        }

    }
}
