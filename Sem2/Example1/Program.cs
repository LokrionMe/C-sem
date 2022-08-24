int FindBiggerDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;

    int result;
    if(ed > dec) result = ed;
    else result = dec;

    return result; 
}

int randNumber = new Random().Next(10, 100);
Console.WriteLine($"Bigger digit of number {randNumber} is {FindBiggerDigit(randNumber)}");