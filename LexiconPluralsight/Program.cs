using LexiconPluralsight;

Console.WriteLine("Create an employee");
Console.WriteLine("-----------------");
Console.WriteLine();
Employee jane = new Employee("Jane", "Doe", new DateTime(1950, 1, 30), 25, EmployeeType.Manager);
jane.PerformWork(50);
jane.ReceiveWage(true);




Console.WriteLine("Create an employee");
Console.WriteLine("-----------------");
Console.WriteLine();
Employee john = new("John", "Doe", new DateTime(1990, 4, 28), 50, EmployeeType.Research);
john.PerformWork(50);
john.ReceiveWage(true);

WorkTask task;
task.description = "bake bread";
task.hours = 1;
task.PerformWorkTask();
