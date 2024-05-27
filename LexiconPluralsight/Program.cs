using LexiconPluralsight.HR;
using LexiconPluralsight.Account;

Console.WriteLine("Create an employee");
Console.WriteLine("-----------------");
Console.WriteLine();
Employee jane = new Employee("Jane", "Doe", new DateTime(1950, 1, 30), 25, EmployeeType.Manager);


Console.WriteLine("Create an employee");
Console.WriteLine("-----------------");
Console.WriteLine();
Employee john = new("John", "Doe", new DateTime(1990, 4, 28), null, EmployeeType.Research);


//---------------------------------------------ENCAPSULATION-------------------------------------------------------

jane.DisplayEmployeeDetails();
jane.PerformWork(4);
jane.PerformWork(6);
jane.PerformWork(2);
jane.PerformWork(9);
jane.ReceiveWage();

//jane.firstName;
jane.FirstName = "Sara";
string fn  = jane.FirstName;
Console.WriteLine($"Jane has change name to {fn}");
jane.Wage = 2000;
jane.NumberOfHoursWorked = 345;