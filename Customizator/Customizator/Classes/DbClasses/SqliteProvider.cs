using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customizator.Classes.DbClasses
{
    public  class SqliteProvider
    {
        private string _connectionPath;
        private string _createScript;
        private SQLiteConnection _connection;
        public SqliteProvider(string connectionPath, string createSqript)
        {
            _connectionPath = connectionPath;
            _createScript = createSqript;
        }

        public void CreateSettingsDataBase()
        {
            if(!File.Exists(_connectionPath))
            {
                File.Create(_connectionPath).Close();
            }
            _connection = new SQLiteConnection("Data Source="+_connectionPath);
            SQLiteCommand cmd = new SQLiteCommand(_createScript, _connection);
            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();

        }

    }
}
