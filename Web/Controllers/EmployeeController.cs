using DataAccess.Context;
using DataAccess.Repositories;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Newtonsoft.Json;

namespace WebArtSofte.Controllers
{
    [Controller]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly EmployeeRepository _employeeRepositories;

        public EmployeeController(ApplicationDbContext _context)
        {
            _employeeRepositories = new EmployeeRepository(_context);
            this._context = _context;

            if (!_context.Employees.Any())
                EmployeesServices.FillEmployees(this._context);
        }
        [HttpGet]
        [Route("/")]
        public IActionResult Employees()
        {
            return View(_employeeRepositories.GetEmployees());
        }

        [HttpGet, ActionName("edit")]
        [Route("edit/{id?}")]
        public ActionResult EmployeeEdit(int id)
        {
            ViewBag.EmployeesDepartents = _context.Departments.ToList();
            ViewBag.EmployeesProgLanguags = _context.ProgrammingLanguages.ToList();

            return View(_employeeRepositories.EditEmployee(id));
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public ActionResult EmployeeEdit(Employee employee)
        {
            _employeeRepositories.EditEmployee(employee);
            return RedirectToAction("Employees");
        }

        [ActionName("delete")]
        [Route("delete/{id?}")]
        public ActionResult EmployeeDelete(int id)
        {
            _employeeRepositories.RemoveEmployee(id);
            return RedirectToAction("Employees");
        }
        [HttpGet, ActionName("add")]
        [Route("add")]
        public ActionResult EmployeeCreate()
        {
            ViewBag.EmployeesDepartents = _context.Departments.ToList();
            ViewBag.EmployeesProgLanguags = _context.ProgrammingLanguages.ToList();

            return View();
        }

        [HttpPost, ActionName("add")]
        [Route("add")]
        public ActionResult EmployeeCreate(Employee employee)
        {
            _employeeRepositories.AddEmployee(employee);
            return RedirectToAction("Employees");
        }
    }
}