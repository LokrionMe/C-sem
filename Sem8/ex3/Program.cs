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
int[,] DeleteRowAndColMinimalNumber(int[,] array)
{
    int minimum = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < minimum)
                minimum = array[i, j];
    Console.WriteLine($"{minimum}");
    int minrow = 0;
    int mincol = 0;
    bool is_break = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (is_break = (array[i, j] == minimum))
            {
                minrow = i;
                mincol = j;
                Console.WriteLine($"{minrow + 1} {mincol + 1}");
                break;
            }
        if (is_break) break;
    }
    int[,] newArr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < newArr.GetLength(0); i++)
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            if (i >= minrow)
            {
                newArr[i, j] = array[i + 1, j];
                if (j >= mincol) newArr[i, j] = array[i + 1, j + 1];
            }
            if (j >= mincol) 
            {
                newArr[i, j] = array[i, j + 1];
                if (i >= mincol) newArr[i, j] = array[i + 1, j + 1];
            }
            if (i < minrow && j < mincol) newArr[i, j] = array[i, j];
        }
    return newArr;
}
int[,] newArr = CreateRandom2dArray();
Print2dArray(newArr);
Print2dArray(DeleteRowAndColMinimalNumber(newArr));