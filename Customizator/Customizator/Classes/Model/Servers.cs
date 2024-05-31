using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customizator.Classes.Model
{
    [Table("Servers")]
    public class Servers
    {
        [Key]
        public int ID { get; set; }
        public string ServerName { get; set; }
        public int DbTypeID { get; set; }            
        
        public int Port { get; set; }
        public string Password { get; set; }
        public string DbName { get; set; }
        public char IsCurrent { get; set; }


        [ForeignKey(nameof(DbTypeID))]
        public DbTypes DbType { get; set; }
    }
}
