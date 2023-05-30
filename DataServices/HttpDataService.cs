namespace DiApi.DataServices
{
    public class HttpDataService : IDataService
    {
        public string GetProductData(string url)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> Getting Product data...");
            Console.ResetColor();

            return "Some PRODUCT data...";
        }
    }
}