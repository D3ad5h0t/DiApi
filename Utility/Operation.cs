namespace DiApi.Utility
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton
    {
        public Operation()
        {
            OperationId = Guid.NewGuid().ToString()[^4..];

        }

        public string OperationId { get; }
    }
}