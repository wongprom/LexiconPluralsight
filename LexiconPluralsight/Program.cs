using LexiconPluralsight.HR;
using LexiconPluralsight.Account;

Console.WriteLine("Create an employee");
Console.WriteLine("-----------------");
Console.WriteLine();
Employee jane = new Employee("Jane", "Doe", new DateTime(1950, 1, 30), 25);
jane.DisplayEmployeeDetails();
jane.PerformWork(4);
jane.PerformWork(6);
jane.PerformWork(2);
jane.PerformWork(9);
jane.ReceiveWage();

Console.WriteLine();
Console.WriteLine("Create an manager");
Console.WriteLine("-----------------");
Manager mary = new("Mary", "Pettersson", new DateTime(1956, 2, 25), 30);
Console.WriteLine();
mary.DisplayEmployeeDetails();
mary.PerformWork(4);
mary.PerformWork(6);
mary.PerformWork(2);
mary.PerformWork(9);
mary.ReceiveWage();
//mary.AttendManagementMeeting();
mary.GiveBonus();

Console.WriteLine();
Console.WriteLine("Create an Junirresearcher");
Console.WriteLine("-----------------");
JuniorResearcher bobJunior = new("Bob", "Andersson", new DateTime(1980, 8, 30), 50);
Console.WriteLine();
bobJunior.ResearcherNewPieTastes(5);
bobJunior.ResearcherNewPieTastes(5);

Console.WriteLine("Create an employee with address");
Console.WriteLine("-----------------");
Console.WriteLine();
Employee jake = new Employee("Jake", "Olsson", new DateTime(1990, 9, 3), 10, "New Street", "69", "12345", "Pie Ville");
string streetName = jake.Adress.Street;

Console.WriteLine();
Console.WriteLine("Create an Junirresearcher");
Console.WriteLine("-----------------");
StoreManager kate = new("Kate", "Jacobsson", new DateTime(1990, 8, 30), 50);
Console.WriteLine();

List<Employee> employees = new List<Employee>();
employees.Add(jane);
employees.Add(jake);
employees.Add(bobJunior);
employees.Add(kate);
employees.Add(mary);

foreach (Employee employee in employees)
{
    employee.DisplayEmployeeDetails();
    employee.GiveBonus();
}