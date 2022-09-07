int [] Febunucci (int size, int a, int b)
{
    int [] array = new int[size];
    array [0] = a;
    array [1] = b;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
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
Console.Write("Input amount of numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
PrintArray(Febunucci(size, a, b));