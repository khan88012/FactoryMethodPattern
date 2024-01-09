// See https://aka.ms/new-console-template for more information
using FactoryMethodPattern;

Console.WriteLine("Factory Method Design Pattern");
IEmployee androidDeveloper = EmployeeFactory.GetEmployee("Android Developer");
int androidSalary = androidDeveloper.salary();
Console.WriteLine(androidSalary);

IEmployee webDeveloper = EmployeeFactory.GetEmployee("web Developer");
int webDevSalary = webDeveloper.salary();
Console.WriteLine(webDevSalary);
