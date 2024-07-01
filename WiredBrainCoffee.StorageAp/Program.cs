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
            AddManagers(employeeRepository);
            GetEmployeeById(employeeRepository);
            WriteAllToConsole(employeeRepository);

            var organizationRepository = new ListRepository<Organization>();
            AddOrganizations(organizationRepository);
            WriteAllToConsole(organizationRepository);


            Console.ReadLine();
        }

        private static void AddManagers(IWriteRepository<Manager> managerRepository)
        {
            var saraManager = new Manager {FirstName = "Sara"};
            var saraManagerCopy = saraManager.Copy();
            managerRepository.Add(saraManager);

            if(saraManagerCopy != null)
            {
                saraManagerCopy.FirstName += "_Copy_";
                managerRepository.Add(saraManagerCopy);
            }

            managerRepository.Add(new Manager{ FirstName = "Henry" });
            managerRepository.Save();
        }

        private static void WriteAllToConsole(IReadRepository<IEntity> employeeRepository)
        {
            var items = employeeRepository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        private static void GetEmployeeById(IRepository<Employee> repository)
        {
            var employee = repository.GetById(2);
            Console.WriteLine($"Employee with Id 2: {employee.FirstName}");
        }

        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
            var employees = new[]
            {
                new Employee { FirstName = "Jimmy", },
                new Employee { FirstName = "Sara" },
                new Employee { FirstName = "Tom" }
            };
            employeeRepository.AddBatch(employees);
        }

        private static void AddOrganizations(IRepository<Organization> organizationRepository)
        {
            var organizations = new[] 
            {
                new Organization { Name = "Smokeless" },
                new Organization { Name = "SAAB" },
                new Organization { Name = "VOLVO" }
            };
            organizationRepository.AddBatch(organizations);
        }

     
    }
}
