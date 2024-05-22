using LexiconPluralsight;

Console.WriteLine("Create an employee");
Console.WriteLine("-----------------");
Console.WriteLine();
Employee jane = new Employee("Jane", "Doe", new DateTime(1950, 1, 30), 25);

//jane.DisplayEmployeeDetails();

/*jane.PerformWork();
jane.PerformWork();
jane.PerformWork();
jane.PerformWork(50);
double recivedWageJane = jane.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {recivedWageJane}");*/
jane.PerformWork(50);
int minimumBonus = 100;
int recivedBonus = jane.CalculateBonus(minimumBonus);
Console.WriteLine($"The minimum bonus is {minimumBonus} and {jane.firstName} has revived a bonus of {recivedBonus}");


/*Console.WriteLine("Create an employee");
Console.WriteLine("-----------------");
Console.WriteLine();
//Instanciate
Employee john = new("John", "Doe", new DateTime(1990, 4, 28), 50);
john.DisplayEmployeeDetails();
john.PerformWork(4);
john.PerformWork(6);
john.PerformWork(2);
double recivedWageJohn =  john.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {recivedWageJohn}");*/
