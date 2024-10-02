using auth.Context;
using auth.Models;
using Microsoft.AspNetCore.Mvc;

namespace auth.Controllers
{
    public class EmployeesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        [HttpGet]
        public IActionResult Index()
        {
            var employees = context.Employees.ToList();
            return View(employees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
            public IActionResult Update()
        {
            return View();
        }
    }
}
