bool ChekNumber(int number)
{
    if ((number % 7 == 0) & (number % 23 == 0)) return true;
    return false;
}
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
Console.WriteLine(ChekNumber(number));