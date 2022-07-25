using System.ComponentModel;

namespace MyFinancialManager.Domain.Enums
{
    public enum ExpenseCategory
    {
        [Description("Contas")]
        Bills = 0,

        [Description("Café")]
        Coffee = 1,

        [Description("Educação")]
        Education = 2,

        [Description("Saúde")]
        Health = 3,

        [Description("Lazer")]
        Leisure = 4,

        [Description("Outros")]
        Others = 5,

        [Description("Presentes")]
        Gifts = 6,

        [Description("Compras")]
        Shopping = 7,

        [Description("Casa")]
        House = 8,

        [Description("Transporte")]
        Transport = 9,

        [Description("Família")]
        Family = 10
    }
}
