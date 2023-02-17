namespace MVC_Final_Assignment.Models
{
    public class Comparison
    {
        public Laptop Laptop1 { get; set; }
        public Laptop Laptop2 { get; set; }

        public Comparison()
        {

        }
        public Comparison(Laptop laptop1, Laptop laptop2)
        {
            Laptop1 = laptop1;
            Laptop2 = laptop2;
        }
    }
}
