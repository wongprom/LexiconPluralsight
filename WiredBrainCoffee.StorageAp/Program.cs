using WiredBrainCoffee.StorageAp.Entities;
using WiredBrainCoffee.StorageAp.Repositories;

namespace WiredBrainCoffee.StorageAp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            employeeRepository.Add(new Employee {FirstName = "Jimmy" });
            employeeRepository.Add(new Employee {FirstName = "Sara" });
            employeeRepository.Add(new Employee {FirstName = "Tom" });
            employeeRepository.Save();

            var organizationRepository = new GenericRepository<Organization>();
            organizationRepository.Add(new Organization { Name = "smokeless" });
            organizationRepository.Add(new Organization { Name = "SAAB" });
            organizationRepository.Add(new Organization { Name = "VOLVO" });
            organizationRepository.Save();

            Console.ReadLine();
        }
    }
}
