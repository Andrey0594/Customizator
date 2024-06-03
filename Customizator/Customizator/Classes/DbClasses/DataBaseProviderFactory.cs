
using Customizator.Classes.Model;
using Microsoft.Extensions.Logging;
using System;

namespace Customizator.Classes.DbClasses
{
    internal class DataBaseProviderFactory
    {
        public static AbstractDataBaseProvider CreateLanDocsProvider(Servers server, ILogger logger =null)
        {
            switch (server.DbType.ID)
            {
                case 1://MSSQLServer
                    return new MicrosoftSQLProvider(server, logger);
                case 2:
                    return new PostgreSQLProvider(server, logger);
                default:
                    throw new Exception("Неподдерживаемый тип базы данных: "
                        + server.DbType.Name);
            }
        }
    }
}
