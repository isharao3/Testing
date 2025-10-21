
using Employees;
namespace Emp
{
    public class Emp
    {
        private static List<Employee> Employees = new List<Employee>() { new Employee() { Name = "Avani", Dept= "sales", Sal="1200"},
         new Employee() { Name = "Pushpa", Dept="Marketing", Sal="100" },
         new Employee() { Name = "Isha", Dept="Engineering", Sal="30000000" }
        };
        public static List<Employee> GetAllEmployees() { return Employees; }
        public static bool AddEmployee(string name, string dept, string sal)
        {
            var result = false;
            try
            {
                Employees.Add(new Employee() { Name = name, Dept=dept, Sal=sal });
                result = true;
            }
            catch { }
            return result;
        }
        //public static GetSDE()
        //{
            
        //}

    }
}
