using System.ComponentModel;

namespace MyFinancialManager.Domain.Enums
{
    public enum IncomeCategory
    {
        [Description("Salário")]
        Salary = 0,

        [Description("Outros")]
        Others = 1,

        [Description("Juros")]
        Fees = 2,

        [Description("Presente")]
        Gift = 3
    }
}
