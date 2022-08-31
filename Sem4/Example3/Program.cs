int fact (int num)
{
    int pr = 1;
    for (int i = 1; i <= num; i++)
    {
        pr *= i;
    }
    return pr;
}
Console.Write("Vvedite celoe chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Factorial = {fact(n)}");