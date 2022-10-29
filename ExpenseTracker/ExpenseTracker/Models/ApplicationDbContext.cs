using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        //add constructor
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }

        //migration the tables corresponding
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions  { get; set; }
    }
}
