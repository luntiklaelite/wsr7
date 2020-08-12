using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsr7.Data;

namespace wsr7.data
{
    public class Rieltor
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Familia { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Otchestvo { get; set; }
        public double Comissia { get; set; }

        public virtual List<Supply> Supplies { get; set; }
        public virtual List<Demand> Demands { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
