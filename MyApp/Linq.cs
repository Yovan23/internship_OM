using MyApp;
using System.Collections.Generic;
using System.Linq;

public class Linq
{
    public static void XYZ()
    {
        // Sample Dataset 1: Employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Yovan", Age = 28, Salary = 50000, DepartmentId = 1 },
            new Employee { Id = 2, Name = "Jay", Age = 35, Salary = 60000, DepartmentId = 2 },
            new Employee { Id = 3, Name = "joy", Age = 32, Salary = 55000, DepartmentId = 1 },
        };

        // Sample Dataset 2: Departments
        List<Department> departments = new List<Department>
        {
            new Department { Id = 1, Name = "HR" },
            new Department { Id = 2, Name = "IT" },
        };

        // 1. Filtering (Where, First, FirstOrDefault)
        var ageAbove30 = employees.Where(e => e.Age > 30);
        Console.WriteLine("Employees above 30:");
        foreach (var emp in ageAbove30) Console.WriteLine(emp.Name);

        var firstEmployee = employees.First();
        Console.WriteLine($"\nFirst Employee: {firstEmployee.Name}");

        var sortedEmployees = employees.OrderBy(e => e.Age);
        Console.WriteLine("\nEmployees sorted by Age:");
        foreach (var emp in sortedEmployees) Console.WriteLine(emp.Name + " - Age: " + emp.Age);

        var employeeNames = employees.Select(e => e.Name);
        Console.WriteLine("\nEmployee Names:");
        foreach (var name in employeeNames) Console.WriteLine(name);

        int totalEmployees = employees.Count();
        int totalSalary = employees.Sum(e => e.Salary);
        double avgSalary = employees.Average(e => e.Salary);
        Console.WriteLine($"\nTotal Employees: {totalEmployees}, Total Salary: {totalSalary}, Average Salary: {avgSalary}");

        var employeeDepartmentJoin = from emp in employees
                                     join dept in departments on emp.DepartmentId equals dept.Id
                                     select new { emp.Name, Department = dept.Name };
        Console.WriteLine("\nEmployee - Department Join:");
        foreach (var item in employeeDepartmentJoin) Console.WriteLine($"{item.Name} - {item.Department}");

    }

}
// Employee Class
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }
    public int DepartmentId { get; set; }
}

// Department Class
class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
}