namespace MyFinancialManager.Domain.Validation
{
    public class DomainException : Exception
    {
        public DomainException(string errorMessage) : base(errorMessage)
        {

        }

        public static void When(bool hasError, string error)
        {
            if (hasError) throw new DomainException(error);
        }
    }
}
