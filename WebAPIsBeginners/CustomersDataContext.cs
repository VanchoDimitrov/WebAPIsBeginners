using Microsoft.EntityFrameworkCore;
using WebAPIsBeginners.Models;

namespace WebAPIsBeginners
{
    public class CustomersDataContext : DbContext
    {
        public CustomersDataContext(DbContextOptions<CustomersDataContext> options) : base(options)
        {
        }

        public DbSet<Customers>? Customers { get; set; } = null;
    }
}
