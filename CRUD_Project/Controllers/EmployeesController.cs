using CRUD_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Project.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.Departments = _context.Departments.OrderBy(x => x.DepartmentName).ToList();
            return View();
        }

    }
}
