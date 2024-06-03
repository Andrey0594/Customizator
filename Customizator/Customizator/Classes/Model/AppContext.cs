using Customizator.Classes.DbClasses;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Customizator.Classes.Model
{
    public  class AppContext:DbContext
    {
        public AppContext(string connectionString): base(GetConnection(connectionString),false)
                                                    //base(GetConnection("Data Source=e:\\Работа\\Программы\\GRKAdmin\\Customizator\\Customizator\\Customizator\\bin\\Debug\\Settings\\Settings.db"),false)
        {

        }
        public static DbConnection GetConnection(string connectionString)
        {
            DbConnection connect = new SQLiteConnection(connectionString);
            return connect;
        }

       

        public DbSet<DbTypes> DbTypes { get; set; }
        public DbSet<ExecScripts> ExecScripts { get; set; }
        public DbSet<ExecScriptTypes> ExecScriptTypes { get; set; }
        public DbSet<Functions> Functions { get; set; }
        public DbSet<Parametrs> Parametrs { get; set; }
        public DbSet<PluginExecScripts> PluginExecScripts { get; set; }
        public DbSet<Servers> Servers { get; set; }
        public DbSet<SqlExecScriptFunctions> SqlExecScriptFunctions { get; set; }
        public DbSet<SqlExecScriptParametrs> SqlExecScriptParametrs { get; set; }
        public DbSet<SqlExecScripts> SqlExecScripts { get; set; }

        




       

    }
}
