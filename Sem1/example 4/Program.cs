Console.Write("Input three-digit integer number:");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;

Console.Write($"Last digit of {num} is {result}");