using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customizator.Classes.Settings
{
    [Serializable]
    public class AppSettings
    {
        public string DbPath { get; set; }
        public static AppSettings LoadDefaultOptions()
        {
            AppSettings appSettings = new AppSettings();
            string dbDirectory = Path.Combine(Application.StartupPath, "Settings");
            string dbPath= Path.Combine(dbDirectory, "Settings.db");
            appSettings.DbPath = dbPath;
            if(!Directory.Exists(dbDirectory))
                Directory.CreateDirectory(dbDirectory);
            if(!File.Exists(dbPath))
                File.Create(dbPath);
            OptionsLoader<AppSettings>.SaveOptionsToXml(appSettings);
            return appSettings;
        }
    }
}
