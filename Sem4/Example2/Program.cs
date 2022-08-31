void NumberOfNumber(int num)
{
    int i = 1;
    while (num / 10 != 0) 
    {
        i += 1;
        num /= 10;
    }
    Console.WriteLine(i); 
}
Console.Write("Vvedite celoe chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
NumberOfNumber(n);