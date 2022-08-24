void Dev2on1(int num1, int num2)
{
    if (num2 % num1 == 0) Console.WriteLine("Yes");
    else Console.WriteLine(num2 % num1);
}
int num1 = new Random().Next(1, 10);
int num2 = new Random().Next(10, 20);
Console.WriteLine(num1);
Console.WriteLine(num2);
Dev2on1(num1, num2);