using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services;

public class OtherEmployeeService : IEmployeeService
{
    List<Employee> employees =
 [
     new Employee()
            {
                Id = 562,
                Name = "TEST Hejlsberg",
                Email = "TEST.h@outlook.com",
            },
            new Employee()
            {
                Id = 62,
                Name = "TEST Dollard",
                Email = "TEST.d@outlook.com",
            },
            new Employee()
            {
                Id = 15662,
                Name = "TEST Torgersen",
                Email = "TEST.t@outlook.com",
            },
            new Employee()
            {
                Id = 52,
                Name = "TEST Hanselman",
                Email = "TEST.h@outlook.com",
            },
            new Employee()
            {
                Id = 563,
                Name = "TEST Skeet",
                Email = "TEST.s@outlook.com",
            },
        ];

    public void Add(Employee employee)
    {
        employee.Id = employees.Count < 0 ? 1 : employees.Max(e => e.Id) + 1;
        employees.Add(employee);
    }

    public Employee[] GetAll() => employees
        .OrderBy(e => e.Name)
        .ToArray();

    public Employee GetById(int id) => employees
        .Single(e => e.Id == id);
}

