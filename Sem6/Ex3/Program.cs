string binarnumb(int num)
{
    string result = " ";
    while (num != 0)
    {
        int res = num % 2;
        num /= 2;
        result = $"{res}" + $"{result}";
    }
    return result;
}
Console.Write("Input unteger number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(binarnumb(n));