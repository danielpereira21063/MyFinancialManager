using MyFinancialManager.Domain.Enums;
using MyFinancialManager.Domain.Validation;

namespace MyFinancialManager.Domain.Entities
{
    //Rendas
    public class Income : AbstractEntity
    {
        public Income()
        {
            DomainException.When(Value <= 0, "Invalid value.");
            DomainException.When(Category.Equals(null), "Category not informed.");
        }

        public string Description { get; set; }
        public decimal Value { get; set; }
        public Category Category { get; set; }
    }

}
