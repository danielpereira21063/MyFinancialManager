using MyFinancialManager.Domain.Entities;
using MyFinancialManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialManager.Data.Repositories
{
    public class IncomeRepository : IIncomeRepository
    {
        public void Add(Income entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Income> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Income> Find(Expression<Func<Income, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Income> GetAll()
        {
            throw new NotImplementedException();
        }

        public Income GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Income entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Income> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Income entity)
        {
            throw new NotImplementedException();
        }
    }
}
