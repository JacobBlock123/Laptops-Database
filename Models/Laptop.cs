using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Final_Assignment.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int BrandId { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public int Year { get; set; }

        public Laptop() { }
        public Laptop(int id, string model, int brandId, decimal price, int year)
        {
            Id = id;
            Model = model;
            BrandId = brandId;
            Price = price;
            Year = year;
        }
    }
}
