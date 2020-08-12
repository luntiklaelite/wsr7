using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsr7.data
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(40)]
        public string login { get; set; }
        [Required]
        [MaxLength(40)]
        public string pass { get; set; }

    }
}
