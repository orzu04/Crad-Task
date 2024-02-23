using Domain;

namespace Ifrastracted;

public class DepartmentServices
{

   List<Department> _departments = new List<Department>();


   public List<Department> GetDepartments( )
   {
    
        return   _departments; 
   }

   public void AddDeparment(Department department)
   {

       _departments.Add(department);

   }
     public int CountDeparment()
     {
   
         return _departments.Count();
     }
}

