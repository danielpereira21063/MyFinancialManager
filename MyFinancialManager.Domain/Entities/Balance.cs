using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialManager.Domain.Entities
{
    public class Balance : AbstractEntity
    {
        public decimal TotalBalance { get; set; }
    }
}
