int[,] CreateRandom2dArray()
{
    Console.Write("Ammount of strings: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ammount of column: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimum: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximum: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Print2dArray(int[,] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}, ");
        if (i != array.GetLength(0) - 1) Console.Write("\b\b;\n ");
        else Console.Write("\b\b]\n");
    }
}
int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0 && row1 < array.GetLength(0)
    && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1,j];
            array[row1,j] = array[row2,j];
            array[row2,j] = temp;
        }
    return array;
}
int[,] newArr = CreateRandom2dArray();
Print2dArray(newArr);
newArr = ChangeRows(newArr, 0, 2);
Print2dArray(newArr);