using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customizator.Classes.Model
{
    [Table("ExecScripts")]
    public class ExecScripts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }
        public int ExecScripttypeID { get; set; }
        public int DbTypeID { get; set; }

        [ForeignKey(nameof(ExecScripttypeID))]
        public ExecScriptTypes ExecScriptType { get; set; }

        [ForeignKey(nameof(DbTypeID))]
        public DbTypes DbType { get; set; }
    }
}
