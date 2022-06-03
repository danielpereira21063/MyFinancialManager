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
    public class ExpenseRepository : IExpenseRepository
    {
        public void Add(Expense entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Expense> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Expense> Find(Expression<Func<Expense, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Expense> GetAll()
        {
            throw new NotImplementedException();
        }

        public Expense GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Expense entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Expense> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Expense entity)
        {
            throw new NotImplementedException();
        }
    }
}
