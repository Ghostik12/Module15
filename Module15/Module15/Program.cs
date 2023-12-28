using System;
using System.Linq;

namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
                new Department() {Id = 1, Name = "Программирование"},
                new Department() {Id = 2, Name = "Продажи"}
            };
            var employees = new List<Employee>()
            {
                new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
                new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
                new Employee() { DepartmentId = 2, Name = "Виктор", Id = 3},
                new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var result = employees.Join(departments,
                employee => employee.DepartmentId,
                dep => dep.Id,
                (employee, dep) =>
                new
                {
                    EmployeeName = employee.Name,
                    DepartmentName = dep.Name
                });

            foreach (var department in result)
                Console.WriteLine(department.EmployeeName + " - " + department.DepartmentName);
        }
    }
}