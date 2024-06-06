using Customizator.Classes.DbClasses;
using Customizator.Classes.Model;
using Customizator.Properties;
using System.Data.Entity;
using System.IO;
using System.Linq;
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
            if(File.Exists(connectionPath))
                Context = new AppContext($"Data Source={connectionPath}");
            else
            {
                SqliteProvider sqlite = new SqliteProvider(connectionPath, Resources.CreateDB);
                sqlite.CreateSettingsDataBase();

            }
            Context.DbTypes.Load();
            CurrentServer = Context.Servers.FirstOrDefault(t => t.IsCurrent == "+");
            Connection = DataBaseProviderFactory.CreateLanDocsProvider(CurrentServer); 
        }
    }
}
