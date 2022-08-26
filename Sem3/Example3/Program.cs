double LenSegment(double x1, double y1, double x2, double y2)
{
    double z = (x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1);
    double result = Math.Sqrt(z);
    return result;
}
Console.Write("Input x1:");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2:");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1:");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2:");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Len = {LenSegment(xA, yA, xB, yB)} ");