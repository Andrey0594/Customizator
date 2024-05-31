using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customizator.Classes.Model
{
    [Table("SqlExecScripts")]
    public class SqlExecScripts
    {
        [Key]
        public int ID { get; set; }
        public string FunctionName {  get; set; }
        public string ScriptText { get; set; }
        public string PluginFormName { get; set; }
        public int DbTypeID { get; set; }

        [ForeignKey(nameof(DbTypeID))]
        public DbTypes DbType { get; set; }
        [ForeignKey(nameof(ID))]
        public ExecScripts ExecScripts { get; set; }
    }
}
