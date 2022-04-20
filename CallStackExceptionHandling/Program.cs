//using CalculatorLib;
using CallStackExceptionHandlingLib;

Console.WriteLine("In main");
Alpha();

static void Alpha()
{
    Console.WriteLine("In Alpha");
    Beta();
}
static void Beta()
{
    Console.WriteLine("In Beta");
    //Calculator.Gamma();
    try
    {
        Calculator.Gamma();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Caught this exception: {ex.Message}");
    }
}