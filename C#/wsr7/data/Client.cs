using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsr7.Data;

namespace wsr7.data
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Familia { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Otchestvo { get; set; }
        [MaxLength(50)]
        public string PhoneNumber { get; set; }
        [MaxLength(50)]
        public string EMail { get; set; }

        public virtual List<Supply> Supplies { get; set; }
        public virtual List<Demand> Demands { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
