using System.Collections.Generic;
using DataAccess.Entities;

namespace DataAccess.Repositories.Base
{
    internal interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        void AddEmployee(Employee employee);
        Employee EditEmployee(int id);
        void EditEmployee(Employee employee);
        void RemoveEmployee(int id);
    }
}
