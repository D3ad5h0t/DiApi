namespace DiApi.Data
{
    public class SqlDataRepo : IDataRepo
    {
        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--> Getting data from SQL Database...");
            Console.ResetColor();

            return ("SQL Data from DB");
        }
    }
}