using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entity
{
    [Table("Classes")]
    public class ClassEntity
    {
        public long id { get; set; }
        public long SchoolId { get; set; }
        public int Year { get; set; }
        public string YearName { get; set; }
    }
}
