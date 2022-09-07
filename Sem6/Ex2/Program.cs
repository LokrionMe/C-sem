bool checkTriangle(int a, int b, int c)
{
    if ((a < b + c) & (b < a + c) & (c < a + b)) return true;
    return false;
}
Console.Write("Input first side: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second side: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third side: ");
int c = Convert.ToInt32(Console.ReadLine());
if (checkTriangle(a, b, c) == true) Console.WriteLine($"Triagle with sides {a}, {b}, {c} is exist");
else Console.WriteLine($"Triagle with sides {a}, {b}, {c} is NOT exist");