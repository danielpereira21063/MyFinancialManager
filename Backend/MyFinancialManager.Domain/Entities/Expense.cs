using MyFinancialManager.Domain.Entities.Abstract;
using MyFinancialManager.Domain.Enums;
using MyFinancialManager.Domain.Validation;

namespace MyFinancialManager.Domain.Entities
{
    //Despesas
    public class Expense : AbstractEntity
    {
        public Expense()
        {
            DomainException.When(Value <= 0, "Invalid value.");
            DomainException.When(Category.Equals(null), "Category not informed.");
        }

        public ExpenseCategory Category;
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Value;
    }
}
