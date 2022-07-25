using System.Linq.Expressions;

namespace MyFinancialManager.Domain.Interfaces
{
    public interface IGenericRepository<Entity>
    {
        ICollection<Entity> GetAll();
        Entity GetById(int id);
        ICollection<Entity> Find(Expression<Func<Entity, bool>> expression);
        void Add(Entity entity);
        void AddRange(ICollection<Entity> entities);
        void Remove(Entity entity);
        void RemoveRange(ICollection<Entity> entities);
        void Update(Entity entity);
    }
}
