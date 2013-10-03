using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PonyApplication.DAL.Models
{
    [Table("Pony")]
    public class Pony
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}