using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customizator.Classes.Model
{
    [Table("PluginExecScripts")]
    public class PluginExecScripts
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey(nameof(ID))]
        public ExecScripts ExecScripts { get; set; }
    }
}
