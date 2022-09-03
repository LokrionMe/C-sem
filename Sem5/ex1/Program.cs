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
int FindNegativeSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
    return sum;
}
int [] newArr = CreateRandomArray(8, -9, 9);
PrintArray(newArr);
Console.WriteLine(FindNegativeSum(newArr));
