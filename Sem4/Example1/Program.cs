void sumFrom1(int num)
{
    int sum = 0;
    for (int i = 1; i < num; i++) 
    {
        sum += i;
    }
    Console.WriteLine($"Summa ot 1 do {num} = {sum}");
}
Console.Write("Vvedite celoe chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
sumFrom1(n);