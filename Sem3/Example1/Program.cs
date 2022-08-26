void SearchChapter(double x, double y)
{
    if (x>0)
    {
        if (y>0) Console.WriteLine("1 chapter");
        else Console.WriteLine("4 chapter");
    }
    else
    {
        if (y>0) Console.WriteLine("2 chapter");
        else Console.WriteLine("3 chapter");
    }
}
Console.Write("Input x:");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y:");
double y = Convert.ToDouble(Console.ReadLine());
SearchChapter(x, y);