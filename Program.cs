Console.Clear();
Console.WriteLine("Task 2");
Console.WriteLine("------");

Console.Write("Enter first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2) Console.WriteLine($"{num1} more {num2}");
else if (num1<num2) Console.WriteLine($"{num2} more {num1}");
else
    Console.WriteLine("The numbers are equal");

Console.ReadLine();
Console.Clear();

Console.WriteLine("Task 4");
Console.WriteLine("------");

Console.Write("Enter first number:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number:");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number:");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (num1>max) max = num1;
if (num2>max) max = num2;
if (num3>max) max = num3;
Console.WriteLine($"Max = {max}");

Console.ReadLine();
Console.Clear();

Console.WriteLine("Task 6");
Console.WriteLine("------");