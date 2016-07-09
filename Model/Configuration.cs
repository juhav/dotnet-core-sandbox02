using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApplication
{
    [Table("Core_Configuration")]
    public class Configuration
    {
        [Key]
        public string Key { get; set; }
        
        public string Value { get; set; }
    }
}
