using DiApi.DataServices;

namespace DiApi.Data
{
    public class NoSqlDataRepo : IDataRepo
    {
        private readonly IDataService _dataService;

        public NoSqlDataRepo(IDataService dataService)
        {
            _dataService = dataService;
        }

        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Getting data from No SQL Database...");
            _dataService.GetProductData("https://something.com/api");
            Console.ResetColor();

            return ("No SQL Data from DB");
        }
    }
}