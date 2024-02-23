using System.Data;

namespace Domain;

public class Employee
{


   public string FirsName { get; set; }

     public string LastName { get; set; }
     public DateTime BirthDay { get; set; }
     public decimal Salary { get; set; }
     public Department Department { get; set; }

}
