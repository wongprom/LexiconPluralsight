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
