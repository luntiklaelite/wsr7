using MySql.Data.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using wsr7.data;
using wsr7.Data;

namespace wsr7.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ModelContext : DbContext
    {
        static ModelContext instance;
        public static ModelContext init() // singleton реализация
        {
            if (instance == null)
                instance = new ModelContext();
            return instance;
        }

        public ModelContext()
            : base("user id=wsr7;password=jW74wbYZ4KQ09uyH;port=3306;server=188.120.248.48;characterset=UTF8;database=wsr7")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deal>()
            .HasRequired(a => a.Supply).WithOptional(a => a.Deal).Map(a => a.MapKey("Supply_ID"));


            modelBuilder.Entity<Deal>()
            .HasRequired(a => a.Demand).WithOptional(a => a.Deal).Map(a => a.MapKey("Demand_ID"));


            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Rieltor> Rieltors { get; set; }
        public virtual DbSet<Deal> Deals { get; set; }
        public virtual DbSet<Supply> Supplies { get; set; }
        //realties
        public virtual DbSet<Realty> Realties { get; set; }
        public virtual DbSet<Flat> Flats { get; set; }
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<Earth> Earths { get; set; }
        //
        public virtual DbSet<Disctrict> Disctricts { get; set; }
        //demands
        public virtual DbSet<Demand> Demands { get; set; }
        public virtual DbSet<FlatDemand> FlatDemands { get; set; }
        public virtual DbSet<HouseDemand> HouseDemands { get; set; }
        public virtual DbSet<EarthDemand> EarthDemands { get; set; }
        

        //

    }

}