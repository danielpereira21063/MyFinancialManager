using MyFinancialManager.Domain.Entities.Abstract;

namespace MyFinancialManager.Domain.Entities
{
    public class Balance : AbstractEntity
    {
        public User User { get; set; }
        public decimal TotalBalance { get; set; }
    }
}
