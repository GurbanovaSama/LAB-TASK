namespace ProniaMVC.Helpers
{
    public static class SqlHelpers
    {
        private static readonly string _connectionStrForMsSql = @"Server=localhost;Database=ProniaDB;Trusted_Connection=True;TrustServerCertificate=True";

        public static string GetConnectionStrForMsSql()
        {
            return _connectionStrForMsSql;
        }
    }
}
