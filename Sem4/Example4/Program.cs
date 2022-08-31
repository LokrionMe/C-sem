int [] CreateRandomArray(int n, int minVal, int maxVal)
{
    int [] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(minVal,maxVal + 1);
    }
    return arr;
}
void PrintArray(int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b]");
}
PrintArray(CreateRandomArray(8, 0, 1));
int [] newArr = CreateRandomArray(8, 0, 1);
PrintArray(newArr);