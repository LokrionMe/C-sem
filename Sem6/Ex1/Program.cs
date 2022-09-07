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
int [] ReverseArray(int [] array)
{
    for (int i = 0, j = array.Length - 1 ; i < j; i++, j--)
    {
        int temp = array[i];
        array [i] = array [j];
        array [j] = temp;
    }
    return array;
}
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal number: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum number: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
int [] newArr = CreateRandomArray(size, minVal, maxVal);
PrintArray(newArr);
int [] revArray = ReverseArray(newArr);
PrintArray(revArray);