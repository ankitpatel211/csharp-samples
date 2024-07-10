static class Sample
{
    public static int IntFunction(int num1)
    {
        return (num1 > 0 ? num1 : num1 * -1);
    }
    public static long LongFunction(long num2)
    {
        return (num2 > 0 ? num2 : num2 * -1);
    }
    public static double DoubleFunction(double num3)
    {
        return (num3 > 0 ? num3 : num3 * -1);
    }
}
class Program
{
    static void Main(string[] args)
    {
        int i = -25;
        long l = -100000L;
        double d = -12.34;
        int j = Sample.IntFunction(i);
        long m = Sample.LongFunction(l);
        double e = Sample.DoubleFunction(d);
        Console.WriteLine(j + "  " + m + "  " + e);
        Console.ReadLine();
    }
}