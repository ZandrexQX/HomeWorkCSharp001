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
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number:");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number:");
int num5 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (num3>max) max = num3;
if (num4>max) max = num4;
if (num5>max) max = num5;
Console.WriteLine($"Max = {max}");

Console.ReadLine();


Console.Clear();
Console.WriteLine("Task 6");
Console.WriteLine("------");

Console.Write("Enter number:");
int num6 = Convert.ToInt32(Console.ReadLine());

if (num6%2==0) Console.WriteLine($"{num6} even number");
else
    Console.WriteLine($"{num6} odd number");

Console.ReadLine();


Console.Clear();
Console.WriteLine("Task 8");
Console.WriteLine("------");

Console.Write("Enter number:");
int num7 = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num7} -> ");
if (num7%2==1) num7 -= 1;

for (int i = 2; i <= num7; i += 2)
{
    Console.Write($"{i} ");
}
Console.ReadLine();
Console.Clear();

/* 
    Ненужные задачи можно закоментировать, для работы 
    какой-нибудь одной. Все блоки самодостаточны.
*/