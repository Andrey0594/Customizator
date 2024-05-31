
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Customizator.Classes.Model
{
    [Table("SqlExecScriptParametrs")]
    public class SqlExecScriptParametrs
    {
        [Key]
        public int SqlExecScriptID { get; set; }
        [Key]
        public int ParametrID { get; set; }

        [ForeignKey(nameof(ParametrID))]
        public SqlExecScripts SqlExecScripts { get; set; }
        [ForeignKey(nameof(ParametrID))]
        public Parametrs Parametr { get; set; }
    }
}
