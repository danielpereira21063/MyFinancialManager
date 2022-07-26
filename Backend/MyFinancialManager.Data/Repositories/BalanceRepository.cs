using MyFinancialManager.Domain.Entities;
using MyFinancialManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyFinancialManager.Data.Repositories
{
    public class BalanceRepository : IBalanceRepository
    {
        public void Add(Balance entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(ICollection<Balance> entities)
        {
            throw new NotImplementedException();
        }

        public ICollection<Balance> Find(Expression<Func<Balance, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public ICollection<Balance> GetAll()
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

        public void RemoveRange(ICollection<Balance> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Balance entity)
        {
            throw new NotImplementedException();
        }
    }
}
