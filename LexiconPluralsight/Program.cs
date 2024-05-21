using LexiconPluralsight;

Console.WriteLine("Create an employee");
Console.WriteLine("-----------------");
Console.WriteLine();

//Instaciate employee
Employee jane = new Employee("Jane", "Doe", new DateTime(1950, 1, 30), 25);

jane.DisplayEmployeeDetails();
jane.PerformWork();
jane.PerformWork();
jane.PerformWork();
jane.PerformWork(12);
double recivedWageJane = jane.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {recivedWageJane}");