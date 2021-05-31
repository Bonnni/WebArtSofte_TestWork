using System.Collections.Generic;
using DataAccess.Context;
using DataAccess.Entities;

namespace DataAccess.Services
{
    public class EmployeesServices
    {
        public static void FillEmployees(ApplicationDbContext context)
        {
            context.AddRange(new List<Department>
            {
                new Department { Name = "Отдел Web Разработки" , BuildingFloor = 1},
                new Department { Name = "Отдел Game Разработки" , BuildingFloor = 2},
                new Department { Name = "Отдел Маркетинга" , BuildingFloor = 3},
                new Department { Name = "Отдел Финансов" , BuildingFloor = 4},
            });
            context.ProgrammingLanguages.AddRange(new List<ProgrammingLanguage>
            {
                new ProgrammingLanguage { Name = "С#" },
                new ProgrammingLanguage { Name = "C++"},
                new ProgrammingLanguage { Name = "Java Script"},
            });
            context.SaveChanges();
            context.AddRange(new List<Employee> {
                        new Employee { FirstName = "Сергей" , LastName = "Чепаев", DepartmentId = 2, Gender = "Мужской", Age = 20, ProgrammingLanguageId = 1 },
                        new Employee { FirstName = "Андрей" , LastName = "Николаев", DepartmentId = 2 , Gender = "Мужской", Age = 23, ProgrammingLanguageId = 1 },
                        new Employee { FirstName = "Вячеслав" , LastName = "Алапаев", DepartmentId = 1 , Gender = "Мужской", Age = 31, ProgrammingLanguageId = 2 },
                        new Employee { FirstName = "Екатерина" , LastName = "Путина", DepartmentId = 2 , Gender = "Женский", Age = 25, ProgrammingLanguageId = 1 },
                        new Employee { FirstName = "Наталья", LastName = "Голубева", DepartmentId = 1, Gender = "Женский", Age = 19, ProgrammingLanguageId = 2 }});
            context.SaveChanges();
        }
    }
}