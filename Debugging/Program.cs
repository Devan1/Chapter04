double a = 4.5;
double b = 2.5;
double answer = Add(a, b);
Console.WriteLine($"{a} + {b} = {answer}");

Console.WriteLine("Press any key to exit. ");
Console.ReadLine();

static double Add(double a, double b)
{
    return a * b;//deliberate bug. 
}