using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsr7.data;

namespace wsr7.Data
{
    public class Demand
    {
        public enum TypeRealty
        {
            house,
            flat,
            earth
        }

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
        [Required]
        public int clientId { get; set; }
        [Required]
        public int rieltorId { get; set; }
        public int? minPrice { get; set; }
        public int? maxPrice { get; set; }

        public virtual Client Client { get; set; }
        public virtual Rieltor Rieltor { get; set; }
        public virtual Deal Deal { get; set; }
        public virtual HouseDemand HouseDemand { get; set; }
        public virtual FlatDemand FlatDemand { get; set; }
        public virtual EarthDemand EarthDemand { get; set; }

        public override string ToString()
        {
            return $"{ID} | {getAddress()} | {getPrice()}";
        }

        public string getAddress()
        {
            return string.Join(", ", Address_City, Address_Street, Address_House, Address_Number);
        }
        public string getPrice()
        {
            return minPrice + " - " + maxPrice;
        }

 
    }
}
