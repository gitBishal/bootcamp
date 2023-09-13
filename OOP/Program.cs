// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("Enter CustomerType");
int customerType = Convert.ToInt32(Console.ReadLine());
var userFactoryClass = new Factory().Create(customerType);
Console.WriteLine("Enter Name");
userFactoryClass.Name = Console.ReadLine();
Console.WriteLine("Enter address");
userFactoryClass.Address = Console.ReadLine();
Console.WriteLine("Enter PhoneNumber");
userFactoryClass.PhoneNumber = Console.ReadLine();
Console.WriteLine("Enter BillAmount");
userFactoryClass.BillAmount = Console.ReadLine();
Console.WriteLine("Enter BillDate");
userFactoryClass.BillDate = Console.ReadLine();
Console.WriteLine(userFactoryClass.ValidateModel());
Console.ReadKey();


