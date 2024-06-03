using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customizator.Classes.Model
{
    [Table("SqlExecScriptFunctions")]
    public class SqlExecScriptFunctions
    {
        [Key, Column(Order = 0)]
        public int SqlExecScriptID { get; set; }
        [Key, Column(Order = 1)]
        public int FunctionID { get; set; }

        [ForeignKey(nameof(SqlExecScriptID))]
        public SqlExecScripts SqlExecScripts { get; set; }
        [ForeignKey(nameof(FunctionID))]
        public Functions Function { get; set; }
    }
}
