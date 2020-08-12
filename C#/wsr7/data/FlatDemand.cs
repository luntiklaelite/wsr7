using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsr7.Data
{
    public class FlatDemand
    {
        [Key]
        public int Demand_ID { get; set; }
        public double? minArea { get; set; }
        public double? maxArea { get; set; }
        public int? minRooms { get; set; }
        public int? maxRooms { get; set; }
        public int? minFloor { get; set; }
        public int? maxFloor { get; set; }

        [ForeignKey("Demand_ID")]
        [Required]
        public virtual Demand Demand { get; set; }
        public string getArea()
        {
            return minArea + " - " + maxArea;
        }
        public string getRooms()
        {
            return minRooms + " - " + maxRooms;
        }
        public string getFloors()
        {
            return minFloor + " - " + maxFloor;
        }
    }
}
