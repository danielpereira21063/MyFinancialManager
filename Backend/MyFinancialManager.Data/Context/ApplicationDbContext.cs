using Microsoft.EntityFrameworkCore;
using MyFinancialManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
