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
bool CheckNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) 
        {
            return true;
        }             
    
        
    }
    return false;

}

Console.Write("Input size of array:");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal number:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum number:");
int maxValue = Convert.ToInt32(Console.ReadLine());
int [] newArr = CreatRandomArray(size, minValue, maxValue);
PrintArray(newArr);
Console.Write("Input cheking number: ");
int chNumber = Convert.ToInt32(Console.ReadLine());
bool check = CheckNumber(newArr, chNumber);
if (check == true) Console.WriteLine("Number is fined");
else Console.WriteLine("Number is empty");