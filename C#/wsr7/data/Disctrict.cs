using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsr7.Data
{
    public class Disctrict
    {
        [Key]
        public int ID { get; set; }
        [Index(IsUnique =true)]
        [MaxLength(90)]
        [Required]
        public string name { get; set; }
        [MaxLength(10000)]
        [Required]
        public string Area { get; set; }
    }
}
