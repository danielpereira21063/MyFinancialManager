using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialManager.Domain.Entities
{
    public abstract class AbstractEntity
    {
        protected int Id;
        protected bool Active;

        protected DateTime CreatedAt;
        protected DateTime UpdatedAt;


        public AbstractEntity()
        {
            if (Id <= 0) CreatedAt = DateTime.Now;

            UpdatedAt = DateTime.Now;
        }
    }
}
