using Microsoft.AspNetCore.Mvc;
using MVC_Final_Assignment.Data;
using MVC_Final_Assignment.Models;
using System.Runtime.InteropServices;

namespace MVC_Final_Assignment.Controllers
{
    public class LaptopsController : Controller
    {
        private readonly LaptopsContext _context;
        public LaptopsController(LaptopsContext context)
        {
            _context = context;
        }

        public IActionResult MostExpensive()
        {
            Laptop[] ordered = _context.Laptops.OrderByDescending(x => x.Price).ToArray();
            if (ordered.Length >= 3)
            {
                Laptop[] expensive = { ordered[0], ordered[1], ordered[2] };
                return View(expensive);
            }

            else
            {
                return View(ordered);
            }
        }

        public IActionResult Cheapest()
        {
            Laptop[] ordered = _context.Laptops.OrderBy(x => x.Price).ToArray();
            if (ordered.Length >= 3)
            {
                Laptop[] cheapest = { ordered[0], ordered[1], ordered[2] };
                return View(cheapest);
            }

            else
            {
                return View(ordered);
            }
        }

        public IActionResult BudgetForm()
        {
            return View();
        }

        public IActionResult Budget(int max)
        {
            Laptop[] budgeted = _context.Laptops.Where(x => x.Price <= max).ToArray();
            budgeted = budgeted.OrderByDescending(x => x.Price).ToArray();
            return View(budgeted);
        }

        public IActionResult CompareForm()
        {
            return View(_context.Laptops);
        }

        [HttpPost]
        public IActionResult CompareForm(string laptop1, string laptop2)
        {
            Comparison compare = new Comparison(_context.Laptops.FirstOrDefault(x => x.Model == laptop1), _context.Laptops.FirstOrDefault(x => x.Model == laptop2));
            return View("Compare", compare);
        }

        public IActionResult Compare(Comparison compare)
        {
            return View(compare);
        }

        public IActionResult NewLaptop(Laptop laptop)
        {
            return View(laptop);
        }
    }
}