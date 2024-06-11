using WiredBrainCoffee.StorageAp.Data;
using WiredBrainCoffee.StorageAp.Entities;
using WiredBrainCoffee.StorageAp.Repositories;

namespace WiredBrainCoffee.StorageAp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new SqlRepository<Employee>(new StorageApDbContext());
            AddEmployees(employeeRepository);
            GetEmployeeById(employeeRepository);
            WriteAllToConsole(employeeRepository);

            var organizationRepository = new ListRepository<Organization>();
            AddOrganizations(organizationRepository);

            Console.ReadLine();
        }

        private static void WriteAllToConsole(SqlRepository<Employee> employeeRepository)
        {
            var items = employeeRepository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        private static void GetEmployeeById(IRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"Employee with Id 2: {employee.FirstName}");
        }

        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { FirstName = "Jimmy", });
            employeeRepository.Add(new Employee { FirstName = "Sara" });
            employeeRepository.Add(new Employee { FirstName = "Tom" });
            employeeRepository.Save();
        }

        private static void AddOrganizations(IRepository<Organization> organizationRepository)
        {
            organizationRepository.Add(new Organization { Name = "smokeless" });
            organizationRepository.Add(new Organization { Name = "SAAB" });
            organizationRepository.Add(new Organization { Name = "VOLVO" });
            organizationRepository.Save();
        }
    }
}
