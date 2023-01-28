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
