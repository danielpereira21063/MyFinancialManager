using MyFinancialManager.Domain.Enums;
using MyFinancialManager.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialManager.Domain.Entities
{
    //Despesas
    public class Expenses : AbstractEntity
    {
        public Expenses()
        {
            DomainException.When(Value <= 0, "Invalid value.");
            DomainException.When(Category.Equals(null), "Category not informed.");
        }

        public decimal Value;
        public Category Category;
    }
}
