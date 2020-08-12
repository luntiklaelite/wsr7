using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsr7.Data
{
    public class Realty // НЕДВИЖИМОСТЬ
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Address_City { get; set; }
        [MaxLength(100)]
        public string Address_Street { get; set; }
        [MaxLength(100)]
        public string Address_House { get; set; }
        [MaxLength(100)]
        public string Address_Number { get; set; }

        public double? Coordinate_latitude { get; set; }
        public double? Coordinate_longitude { get; set; }

        public virtual Earth Earth { get; set; }
        public virtual Flat Flat { get; set; }
        public virtual House House { get; set; }

        public virtual List<Supply> Supplies { get; set; }

        public override string ToString()
        {
            return getAddress();
        }

        public string getAddress()
        {
            return string.Join(", ", Address_City, Address_Street, Address_House, Address_Number);
        }

        public string getAddress(string znak) // передача знака через полиморфизм
        {
            return string.Join(znak, Address_City, Address_Street, Address_House, Address_Number);
        }

    }
}
