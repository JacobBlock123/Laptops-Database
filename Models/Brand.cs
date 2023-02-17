using Microsoft.EntityFrameworkCore;

namespace MVC_Final_Assignment.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public Brand(string name, int id)
        {
            Id = id;
            Name = name;
        }

        public Brand() { }
    }
}
