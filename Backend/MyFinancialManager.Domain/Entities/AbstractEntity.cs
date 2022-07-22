namespace MyFinancialManager.Domain.Entities
{
    public abstract class AbstractEntity
    {
        protected int Id;
        protected bool Active;
        protected DateTime CreatedAt;

        public AbstractEntity()
        {
            if (Id <= 0) CreatedAt = DateTime.Now;
            Active = true;
        }

    }
}
