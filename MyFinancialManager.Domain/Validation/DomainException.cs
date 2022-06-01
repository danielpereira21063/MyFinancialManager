using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialManager.Domain.Validation
{
    public class DomainException : Exception
    {
        public DomainException(string errorMessage) : base(errorMessage)
        {

        }

        public static void When(bool hasError, string error)
        {
            if (hasError) throw new DomainException(error);
        }
    }
}
