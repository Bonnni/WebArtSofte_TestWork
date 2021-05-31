using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Entities;
using DataAccess.Context;
using DataAccess.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class EmployeeRepository
        : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context
                .Employees
                .Include(x => x.Departments)
                .Include(x => x.ProgrammingLanguages)
                .ToList();
        }


        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public Employee EditEmployee(int id)
        {
            return GetEmployees().Where(x => x.Id == id).FirstOrDefault();
        }

        public void EditEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        public void RemoveEmployee(int id)
        {
            var emp = _context.Employees.FirstOrDefault(x => x.Id == id);
            _context.Employees.Remove(emp ?? throw new InvalidOperationException());
            _context.SaveChanges();
        }
    }
}