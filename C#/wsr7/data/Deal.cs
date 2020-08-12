using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsr7.Data
{
    public class Deal
    {
        [Key]
        public int ID { get; set; }

        public virtual Supply Supply { get; set; }
        public virtual Demand Demand { get; set; }
    }

  
}
