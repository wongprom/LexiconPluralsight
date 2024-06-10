using WiredBrainCoffee.StorageAp.Entities;
using WiredBrainCoffee.StorageAp.Repositories;

namespace WiredBrainCoffee.StorageAp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new EmployeeRepository();
            employeeRepository.Add(new Employee {FirstName = "Jimmy" });
            employeeRepository.Add(new Employee {FirstName = "Sara" });
            employeeRepository.Add(new Employee {FirstName = "Tom" });
            employeeRepository.Save();

            Console.ReadLine();
        }
    }
}
