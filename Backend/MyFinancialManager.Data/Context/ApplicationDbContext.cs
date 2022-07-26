using Microsoft.EntityFrameworkCore;
using MyFinancialManager.Domain.Entities;

namespace MyFinancialManager.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Balance> Balance;
        public DbSet<Expense> Expenses;
        public DbSet<Income> Incomes;
        public DbSet<User> Users;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

    }
}
