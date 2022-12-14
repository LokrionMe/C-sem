int[,] CreateRandom2dArray(int m, int n, int minimum, int maximum)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(minimum, maximum);
    return array;
}
void Print2dArray(int[,] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"({i + 1};{j + 1}) {array[i, j]}, ");
        if (i != array.GetLength(0) - 1) Console.Write("\b\b;\n ");
        else Console.Write("\b\b]");
    }
}
Console.Write("Ammount of strings: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ammount of column: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum: ");
int minValue = Convert.ToInt32(Console.ReadLine());
int[,] newArr = CreateRandom2dArray(m, n, minValue, maxValue);
Print2dArray(newArr);