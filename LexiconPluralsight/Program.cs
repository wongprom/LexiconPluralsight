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

Account account = new Account("111222");
account.AccountNumber = "657657567657";// error. Cant change after its been instanciate.