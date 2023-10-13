
namespace CANestedTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine(employee.EmployeeInsurance.CompanyName);

            Console.ReadKey();  
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }

        public Insurance EmployeeInsurance { get; set; }

        public Employee() => EmployeeInsurance = new Insurance() { Id = 1, CompanyName = "Test", };
            
                
        public class Insurance
        {
            public int Id { get; set; }
            public string CompanyName { get; set; }
        }

    }
    
    class Department
    {
        public int Id { get; set; }
        public string DepName { get; set; }
    }


}