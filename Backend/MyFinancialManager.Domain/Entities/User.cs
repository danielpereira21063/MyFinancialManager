using MyFinancialManager.Domain.Entities.Abstract;

namespace MyFinancialManager.Domain.Entities
{
    public class User : AbstractEntity
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Expense> Incomes { get; set; }
    }
}