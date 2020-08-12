using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsr7.Data
{
    public class Earth
    {
        [Key]
        public int Realty_ID { get; set; }
        public double TotalArea { get; set; }

        [ForeignKey("Realty_ID")]
        [Required]
        public virtual Realty Realty { get; set; }
    }
}
