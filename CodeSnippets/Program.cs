using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 5; ++i)
                Console.WriteLine(arr[i]);
            int val = (1 / Convert.ToInt32(0));
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("IndexOutOfRangeException");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("DivideByZeroException");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("ArithmeticException");
        }
        Console.ReadLine();
    }
}