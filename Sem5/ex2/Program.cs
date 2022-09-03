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
int [] ChangeZnak (int[] array)
{
    int [] chArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        chArray[i] = array[i] * (-1);
    }
    return chArray;
}
Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal number: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum number: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
int [] newArr = CreateRandomArray(size, minVal, maxVal);
PrintArray(newArr);
PrintArray(ChangeZnak(newArr));