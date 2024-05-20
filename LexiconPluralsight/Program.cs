// See https://aka.ms/new-console-template for more information
using LexiconPluralsight;

Console.WriteLine("Hello, World!");

int amount = 23;
int months = 10;
int yearlyWage = Utilities.CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage : {yearlyWage}");
Console.ReadLine();

