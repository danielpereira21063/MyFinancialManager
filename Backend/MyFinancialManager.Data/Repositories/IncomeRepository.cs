using MyFinancialManager.Domain.Entities;
using MyFinancialManager.Domain.Interfaces;
using System.Linq.Expressions;

namespace MyFinancialManager.Data.Repositories
{
    public class IncomeRepository : IIncomeRepository
    {
        public void Add(Income entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(ICollection<Income> entities)
        {
            throw new NotImplementedException();
        }

        public ICollection<Income> Find(Expression<Func<Income, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public ICollection<Income> GetAll()
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

        public void RemoveRange(ICollection<Income> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Income entity)
        {
            throw new NotImplementedException();
        }
    }
}
