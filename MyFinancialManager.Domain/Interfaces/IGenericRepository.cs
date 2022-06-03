using System.Linq.Expressions;

namespace MyFinancialManager.Domain.Interfaces
{
    public interface IGenericRepository<Entity>
    {
        IEnumerable<Entity> GetAll();
        Entity GetById(int id);
        IEnumerable<Entity> Find(Expression<Func<Entity, bool>> expression);
        void Add(Entity entity);
        void AddRange(IEnumerable<Entity> entities);
        void Remove(Entity entity);
        void RemoveRange(IEnumerable<Entity> entities);
        void Update(Entity entity);
    }
}
