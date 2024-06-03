using System.Data;
using Microsoft.Extensions.Logging;
using Microsoft.Data.SqlClient;
using Customizator.Classes.Model;
using System;
using System.Linq;


namespace Customizator.Classes.DbClasses
{
    /// <summary>
    /// Класс подключения к MSSQL Server
    /// </summary>
    public class MicrosoftSQLProvider : AbstractDataBaseProvider
    {
        /// <summary>
        ///Подключение к БД
        /// </summary>
        protected SqlConnection _connection;
        /// <summary>
        /// Конструктор для класса подключения к MSSQL Server
        /// </summary>
        /// <param name="server">Текущие настройки подключения</param>
        /// <param name="logger">Логгер</param>
        public MicrosoftSQLProvider(Servers server, ILogger logger = null)
        {
            _server = server;
            _logger = logger;
        }

        /// <summary>
        /// Метод открытия соединения с БД
        /// </summary>
        /// <returns>
        /// true-соединение установлено, false-ошибка соединения
        /// </returns>
        
        public override bool Connect()
        {
            try
            {
                if (!base.Connect())
                    return false;
                
                _connection = new SqlConnection(
                        $"Server={_server.ServerName};" +
                        $"User Id={_server.User};" +
                        $"Password={_server.Password};" +
                        $"Database={_server.DbName};") ;
                _connection.Open();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Ошибка подключения к СУБД: {ex.Message}");
                throw;
            }
            string now = SelectValue("SELECT GETDATE()").ToString();
            return !string.IsNullOrWhiteSpace(now);

            throw new NotImplementedException("Метод не реализован");
        }
        /// <summary>
        /// Метод закрытия соединения с БД
        /// </summary>
        /// <returns>
        /// true-соединение закрыто, false-ошибка разрыва соединения
        /// </returns>
        public override bool Disconnect()
        {
            if (!base.Disconnect())
                return false;

            _connection.Close();
            return true;
        }

        public override void ExecuteCommand(string commandText)
        {
            lock (_connection)
            {
                try
                {
                    using SqlCommand cmd = _connection.CreateCommand();
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = commandText;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    LogError(ex, commandText);
                    throw;
                }
            }
        }

        public override object SelectValue(string queryText)
        {
            lock (_connection)
            {
                try
                {
                    using SqlCommand cmd = _connection.CreateCommand();
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = queryText;
                        return cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    LogError(ex, queryText);
                    throw;
                }
            }
        }

        public override DataSet SelectDataSet(string queryText)
        {
            lock (_connection)
            {
                try
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(queryText, _connection))
                    {
                        DataSet ds = new DataSet();
                        ds.Reset();
                        da.Fill(ds);
                        return ds;
                    }
                }
                catch (Exception ex)
                {
                    LogError(ex, queryText);
                    throw;
                }
            }
        }

        public override void ExecuteFunction(string functionName, object[] parameters)
        {
            ExecuteCommand("EXEC " + functionName + " " +
                 string.Join(",",
                 parameters?.Select(p => p is string ? $"'{p.ToString().Replace("'","''")}'" : p?.ToString() ?? "NULL")
                 ?? Array.Empty<string>()));
        }

        public override object SelectValueFromFunction(string functionName, object[] parameters)
        {
            return SelectValue("EXEC " + functionName + " " +
                string.Join(",",
                parameters?.Select(p => p is string ? $"'{p.ToString().Replace("'", "''")}'" : p?.ToString() ?? "NULL")
                ?? Array.Empty<string>()));
        }

        public override DataSet SelectDataSetFromFunction(string functionName, object[] parameters)
        {
            return SelectDataSet("EXEC " + functionName + " " +
                string.Join(",",
                parameters?.Select(p => p is string ? $"'{p.ToString().Replace("'", "''")}'" : p?.ToString() ?? "NULL")
                ?? Array.Empty<string>()));
        }
    }
}
