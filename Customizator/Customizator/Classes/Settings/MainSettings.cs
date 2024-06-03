using Customizator.Classes.DbClasses;
using Customizator.Classes.Model;
using System;
using AppContext = Customizator.Classes.Model.AppContext;


namespace Customizator.Classes.Settings
{
    public class MainSettings
    {
        public AppContext Context;
        public AbstractDataBaseProvider Connection;
        public Servers CurrentServer;

        public MainSettings(string connectionPath)
        {
            Context = new AppContext($"Data Source={connectionPath}");
        }
    }
}
