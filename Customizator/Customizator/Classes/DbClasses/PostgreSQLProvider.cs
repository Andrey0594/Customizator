using System.Data;
using Npgsql;
using Microsoft.Extensions.Logging;
using Customizator.Classes.Model;
using System;
using System.Linq;


namespace Customizator.Classes.DbClasses
{
    public class PostgreSQLProvider : AbstractDataBaseProvider
    {
        protected NpgsqlConnection _connection;

        public PostgreSQLProvider(Servers server, ILogger logger = null)
        {
            _server = server;
            _logger = logger;
        }

        public override bool Connect()
        {
            try
            {
                if (!base.Connect())
                    return false;

                _connection = new NpgsqlConnection(
                        $"Server={_server.ServerName};" +
                        $"Port={_server.Port};" +
                        $"User Id={_server.User};" +
                        $"Password={_server.Password};" +
                        $"Database={_server.DbName};" );
                _connection.Open();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Ошибка подключения к СУБД: {ex.Message}");
                throw;
            }
            string now = SelectValueFromFunction("now", null).ToString();
            return !string.IsNullOrWhiteSpace(now);
        }

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
                    using NpgsqlCommand cmd = _connection.CreateCommand();
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
                    using NpgsqlCommand cmd = _connection.CreateCommand();
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
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryText, _connection))
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
            ExecuteCommand("SELECT " + functionName + "(" +
                 string.Join(",",
                 parameters?.Select(p => p is string ? $"'{p}'" : p?.ToString() ?? "NULL")
                 ?? Array.Empty<string>()) + ")");
        }

        public override object SelectValueFromFunction(string functionName, object[] parameters)
        {
            return SelectValue("SELECT " + functionName + "(" +
                string.Join(",",
                parameters?.Select(p => p is string ? $"'{p}'" : p?.ToString() ?? "NULL")
                ?? Array.Empty<string>()) + ")");
        }

        public override DataSet SelectDataSetFromFunction(string functionName, object[] parameters)
        {
            return SelectDataSet("SELECT * FROM " + functionName + "(" +
                string.Join(",",
                parameters?.Select(p => p is string ? $"'{p}'" : p?.ToString() ?? "NULL")
                ?? Array.Empty<string>()) + ")");          
        }
    }
}
