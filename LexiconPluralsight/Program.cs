using LexiconPluralsight.HR;
using LexiconPluralsight.Account;

/*Console.WriteLine("Create an employee");
Console.WriteLine("-----------------");
Console.WriteLine();
Employee jane = new Employee("Jane", "Doe", new DateTime(1950, 1, 30), 25, EmployeeType.Manager);


Console.WriteLine("Create an employee");
Console.WriteLine("-----------------");
Console.WriteLine();
Employee john = new("John", "Doe", new DateTime(1990, 4, 28), null, EmployeeType.Research);

        
#region First run Jane
jane.PerformWork();
jane.PerformWork();
jane.PerformWork(5);
jane.ReceiveWage();
jane.DisplayEmployeeDetails();
#endregion

#region First run John
john.PerformWork(3);
john.PerformWork(5);
john.PerformWork(5);
john.ReceiveWage();
john.DisplayEmployeeDetails();
#endregion

Employee.DisplayTaxRate();

Account account = new Account("111222");*/
//account.AccountNumber = "657657567657";// error. Cant change after its been instanciate.

// ----------------------------------------------------------------ARRAYS----------------------------------------
/*int[] sampleArray1 = new int[5];
int[] sampleArray2 = new int[] {1,2,3,4,5};
//int[] sampleArray3 = new int [5] {1,2,3,4,5,6};
Console.WriteLine("How many employees ID's do you want to register?");
int length = int.Parse(Console.ReadLine());
int[] employeeIds = new int[length];

for (int i = 0; i < length; i++)
{
    Console.Write("Enter the employee ID: ");
    int id = int.Parse(Console.ReadLine());
    employeeIds[i] = id;
}

for (int i = 0;i < employeeIds.Length; i++)
{
    Console.WriteLine($"ID {i + 1} : {employeeIds[i]}");
}*/
// ----------------------------------------------------------------ARRAYS-END---------------------------------------
Employee bethany = new Employee("Bethany", "Smith", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
Employee george = new("George", "Jones", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
Employee mary = new Employee("Mary", "Jones", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
Employee bobJunior = new Employee("Bob", "Spencer", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
Employee kevin = new Employee("Kevin", "Marks", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
Employee kate = new Employee("Kate", "Greggs", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
Employee kim = new Employee("Kim", "Jacobs", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

Employee[] employees = new Employee[7];

employees[0] = bethany;
employees[1] = george;
employees[2] = mary;
employees[3] = bobJunior;
employees[4] = kevin;
employees[5] = kate;
employees[6] = kim;

foreach (Employee e in employees)
{
    e.DisplayEmployeeDetails();
    var numberOfHoursWorked = new Random().Next(25);
    e.PerformWork(numberOfHoursWorked);
    e.ReceiveWage();
    Console.WriteLine();
}