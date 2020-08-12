using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using wsr7.data;

namespace wsr7.Data
{
    public class Supply
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public int rieltorId { get; set; }
        [Required]
        public int clientId { get; set; }
        [Required]
        public int realtyId { get; set; }

        public virtual Deal Deal { get; set; }
        public virtual Rieltor rieltor { get; set; }
        public virtual Client client { get; set; }
        public virtual Realty Realty { get; set; }

        public override string ToString()
        {
            return ID + " | " + Realty.getAddress() + " | " + price; 
        }

        public bool Compare(Demand d)
        {
            if (price == 0 || ((d.minPrice == null || d.minPrice <= price) && (d.maxPrice == null || d.maxPrice >= price)) && // проверка цены
                (Realty.Address_City == null || d.Address_City == null ? true : Realty.Address_City == d.Address_City) && (Realty.Address_House == null || d.Address_House == null ? true : Realty.Address_House == d.Address_House) && (Realty.Address_Number == null || d.Address_Number == null ? true : Realty.Address_Number == d.Address_Number) && (Realty.Address_Street == null || d.Address_Street == null ? true : Realty.Address_Street == d.Address_Street) &&
                ((Realty.Earth != null && d.EarthDemand != null &&
                       (d.EarthDemand.maxArea == null ? true : Realty.Earth.TotalArea <= d.EarthDemand.maxArea) && (d.EarthDemand.minArea == null ? true : Realty.Earth.TotalArea >= d.EarthDemand.minArea)
                       ) || // проверка свойств земли
                (Realty.Flat != null && d.FlatDemand != null &&
                        (Realty.Flat.Rooms == null || d.FlatDemand.maxRooms == null ? true : Realty.Flat.Rooms <= d.FlatDemand.maxRooms) && (Realty.Flat.Rooms == null || d.FlatDemand.minRooms == null ? true : Realty.Flat.Rooms >= d.FlatDemand.minRooms) &&
                        (Realty.Flat.TotalArea == null || d.FlatDemand.minArea == null ? true : d.FlatDemand.minArea <= Realty.Flat.TotalArea) && (Realty.Flat.TotalArea == null || d.FlatDemand.maxArea == null ? true : Realty.Flat.TotalArea <= d.FlatDemand.maxArea) &&
                        (Realty.Flat.Floor == null || d.FlatDemand.minFloor == null ? true : d.FlatDemand.minFloor <= Realty.Flat.Floor) && (Realty.Flat.Floor == null || d.FlatDemand.maxFloor == null ? true : Realty.Flat.Floor <= d.FlatDemand.maxFloor)
                        ) || // проверка свойств квартиры
                (Realty.House != null && d.HouseDemand != null &&
                        (d.HouseDemand.maxArea == null || Realty.House.TotalArea == null ? true : Realty.House.TotalArea <= d.HouseDemand.maxArea) && (d.HouseDemand.minArea == null || Realty.House.TotalArea == null ? true : Realty.House.TotalArea >= d.HouseDemand.minArea) &&
                        (d.HouseDemand.maxFloors == null || Realty.House.TotalFloors == null ? true : Realty.House.TotalFloors <= d.HouseDemand.maxFloors) && (d.HouseDemand.minFloors == null || Realty.House.TotalFloors == null ? true : Realty.House.TotalFloors >= d.HouseDemand.minFloors) &&
                        (d.HouseDemand.maxRooms == null || Realty.House.Rooms == null ? true : Realty.House.Rooms <= d.HouseDemand.maxRooms) && (d.HouseDemand.minRooms == null || Realty.House.Rooms == null ? true : Realty.House.Rooms >= d.HouseDemand.minRooms)
                       )) // проверка свойств дома
                       )
                return true;
            return false;
        }



    }
}
