Console.Write("Input first integer number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine($"{num1} is a quad of {num2}");
}
else
{
    Console.WriteLine($"{num1} is not a quad of {num2}");
}