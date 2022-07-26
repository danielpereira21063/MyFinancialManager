using MyFinancialManager.Domain.Entities;
using MyFinancialManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyFinancialManager.Data.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        public void Add(Expense entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(ICollection<Expense> entities)
        {
            throw new NotImplementedException();
        }

        public ICollection<Expense> Find(Expression<Func<Expense, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public ICollection<Expense> GetAll()
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

        public void RemoveRange(ICollection<Expense> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Expense entity)
        {
            throw new NotImplementedException();
        }
    }
}
