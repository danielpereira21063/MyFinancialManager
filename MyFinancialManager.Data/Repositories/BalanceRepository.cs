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
    public class BalanceRepository : IBalanceRepository
    {
        public void Add(Balance entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Balance> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Balance> Find(Expression<Func<Balance, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Balance> GetAll()
        {
            throw new NotImplementedException();
        }

        public Balance GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Balance entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Balance> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Balance entity)
        {
            throw new NotImplementedException();
        }
    }
}
