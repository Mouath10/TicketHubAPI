using Microsoft.EntityFrameworkCore;

namespace TicketHubAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<TicketPurchase> TicketPurchases { get; set; }
    }
}
