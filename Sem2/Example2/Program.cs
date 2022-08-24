int Doing2From3(int number)
{
    int ed = number % 10;
    int hun = number / 100;
    int result = hun * 10 + ed;
    return result;
}

int randNumber = new Random().Next(100, 1000);
Console.WriteLine($"Bigger digit of number {randNumber} is {Doing2From3(randNumber)}");