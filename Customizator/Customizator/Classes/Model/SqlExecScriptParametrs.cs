
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Customizator.Classes.Model
{
    [Table("SqlExecScriptParametrs")]
    public class SqlExecScriptParametrs
    {
        [Key, Column(Order = 0)]
        public int SqlExecScriptID { get; set; }
        [Key, Column(Order = 1)]
        public int ParametrID { get; set; }

        [ForeignKey(nameof(ParametrID))]
        public SqlExecScripts SqlExecScripts { get; set; }
        [ForeignKey(nameof(ParametrID))]
        public Parametrs Parametr { get; set; }
    }
}
