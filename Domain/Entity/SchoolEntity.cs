using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("Schools")]
    public class SchoolEntity
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public int Students { get; set; }
        public decimal Grade { get; set; }

    }
}
