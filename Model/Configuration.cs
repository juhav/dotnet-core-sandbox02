using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApplication
{
    [Table("core_configuration")]
    public class Configuration
    {
        [Key]
        [Column("key")]
        public string Key { get; set; }
        
        [Column("value")]
        public string Value { get; set; }
    }
}
