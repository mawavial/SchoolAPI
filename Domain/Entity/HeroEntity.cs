using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entity
{
    [Table("Heroes")]
    public class HeroEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
