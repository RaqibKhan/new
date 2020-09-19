using System;
using System.Data.Entity;
using System.Web;

namespace RaqibKhan1.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Model { get; set; }
      
        public decimal Price { get; set; }

    }
    public class CarDBContext : DbContext
    {
        public DbSet<Car> Movies { get; set; }
    }
}

