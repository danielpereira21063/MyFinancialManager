namespace MyFinancialManager.Domain.Entities.Abstract
{
    public abstract class AbstractEntity
    {
        protected int Id;
        public bool Inactive;
        protected DateTime CreatedAt;

        public AbstractEntity()
        {
            if (Id <= 0)
            {
                CreatedAt = DateTime.Now;
            }
        }
    }
}
