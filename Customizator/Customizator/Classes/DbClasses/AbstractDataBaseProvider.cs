using System;
using System.Data;
using Customizator.Classes.Model;
using Microsoft.Extensions.Logging;

namespace Customizator.Classes.DbClasses
{
    public delegate string AccountDataQuery();

    public abstract class AbstractDataBaseProvider : IDisposable
    {
        protected ILogger _logger;

        protected Servers _server;

        public virtual bool Connect()
        {
            if (string.IsNullOrWhiteSpace(_server.ServerName))
                throw new Exception("Не указано имя сервера СУБД (параметр \"ServerName\")");
            if (string.IsNullOrWhiteSpace(_server.DbName))
                throw new Exception("Не указано имя базы данных (параметр \"DataBaseName\")");
            _logger?.LogInformation($"Подключение к базе данных \"{_server.DbName}\" на сервере {_server.ServerName}");
            return true;
        }

        public virtual bool Disconnect()
        {
            _logger.LogInformation($"Отключение от базы данных \"{_server.DbName}\"");
            return true;
        }

        public void Dispose()
        {
            Disconnect();
        }

        public virtual void LogError(System.Exception e, string commandText)
        {
            string errorText = e.Message;
            if (e.InnerException != null)
            {
                errorText += $" ({e.InnerException.Message})";
            }
            _logger.LogError($"Ошибка выполнения запроса: {errorText}\nТекст запроса: {commandText}");
        }

        public abstract void ExecuteCommand(string commandText);

        public abstract object SelectValue(string queryText);

        public abstract DataSet SelectDataSet(string queryText);

        public abstract void ExecuteFunction(string functionName, object[] parameters);

        public abstract object SelectValueFromFunction(string functionName, object[] parameters);

        public abstract DataSet SelectDataSetFromFunction(string functionName, object[] parameters);
    }
}
