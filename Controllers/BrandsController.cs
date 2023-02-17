using Microsoft.AspNetCore.Mvc;
using MVC_Final_Assignment.Data;
using MVC_Final_Assignment.Models;

namespace MVC_Final_Assignment.Controllers
{
    public class BrandsController : Controller
    {
        private readonly LaptopsContext _context;
        public BrandsController(LaptopsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BrandOrderingForm()
        {
            return View(_context.Brands);
        }


        /*        public IActionResult BrandOrdering(string brand, string order, string sort, string filter, string highorlow, int num)
                {
                    List<Laptop> ordered = Database.Laptops.Where(x => x.Brand.Name == brand).ToList();

                    if (sort == "price")
                    {
                        if (order == "asc")
                        {
                            ordered = ordered.OrderBy(x => x.Price).ToList();
                        }

                        else
                        {
                            ordered = ordered.OrderByDescending(x => x.Price).ToList();
                        }
                    }

                    else
                    {
                        if (order == "asc")
                        {
                            ordered = ordered.OrderBy(x => x.Year).ToList();
                        }

                        else
                        {
                            ordered = ordered.OrderByDescending(x => x.Year).ToList();
                        }
                    }

                    if (filter == "price")
                    {
                        if (highorlow == "higher")
                        {
                            ordered = ordered.Where(x => x.Price > num).ToList();
                        }

                        else
                        {
                            ordered = ordered.Where(x => x.Price < num).ToList();
                        }
                    }

                    else
                    {
                        if (highorlow == "higher")
                        {
                            ordered = ordered.Where(x => x.Year > num).ToList();
                        }

                        else
                        {
                            ordered = ordered.Where(x => x.Year < num).ToList();
                        }
                    }

                    return View(ordered);
                }
        */
        /*        public IActionResult LaptopsByBrand()
                {
                    Dictionary<Brand, List<Laptop>> laptopByBrand = new Dictionary<Brand, List<Laptop>>();

                    foreach (var v in Database.Brands)
                    {
                        laptopByBrand.Add(v, Database.Laptops.Where(x => x.Brand == v).ToList());
                    }

                    return View(laptopByBrand);
                }*/

        public IActionResult NewBrand(Brand brand)
        {
            return View(brand);
        }
    }
}
