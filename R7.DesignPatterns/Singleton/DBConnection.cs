namespace R7.DesignPattern.Singleton
{
    public class DBConnection
    {
        private static DBConnection? _instance;

        private DBConnection() { }

        public static DBConnection GetInstance()
        {
            if(_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }
    }
}
