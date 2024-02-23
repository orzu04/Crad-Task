using Domain;


namespace Ifrastracted;

public class EmployeeServices
{
    List<Employee> _employees = new List<Employee>();

    public List<Employee> GetEmployees()
    {
        return _employees;
    }

    public void AddEmloyees(Employee employee)
    {
        _employees.Add(employee);
    }


    public int CountEmployee(Employee employee)
    {
          

        return _employees.Count();
    }
}
