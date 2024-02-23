

using Domain;
using Ifrastracted;




var employeeServices = new EmployeeServices();

var departmentServices = new DepartmentServices();
var employee2= new Employee()
{

    FirsName = "anthoni",
    LastName = "Jorshua",
    BirthDay = DateTime.Now,
    Salary = 22222,

};



var department1 = new Department();



   department1. Name = "Floyd",
   department1. Description = "Bachai zuray",
  department1.  Meneger =  employee2;


var employee = new EmployeeServices();
var employee1 = new Employee();
   employee1.FirsName = "anthoni";
   employee1.LastName = "Jorshua";
   employee1. BirthDay = DateTime.Now;
   employee1. Salary = 22222;
    employee1.Department = department1;

  

foreach (var item in employeeServices.GetEmployees())
{
    System.Console.WriteLine(item.FirsName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.Salary);
}

foreach (var item in departmentServices.GetDepartments())
{
    System.Console.WriteLine(item.Name);
}

