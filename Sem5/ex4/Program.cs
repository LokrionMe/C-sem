int [] CreatRandomArray(int size, int minValue, int maxValue)
{
    int [] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(minValue,maxValue);
    }
    return array;
}
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int [] FirstAndLast (int [] array)
{
    int [] arr = new int [array.Length / 2 + array.Length % 2];
    for (int i = 0; i < (array.Length / 2 + array.Length % 2); i++)
    {
        arr[i] = array[i] * array[array.Length - i - 1];
    }
    return arr;
}

Console.Write("Input size of array:");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal number:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum number:");
int maxValue = Convert.ToInt32(Console.ReadLine());
int [] newArr = CreatRandomArray(size, minValue, maxValue);
PrintArray(newArr);
PrintArray(FirstAndLast(newArr));