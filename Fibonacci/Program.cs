// See https://aka.ms/new-console-template for more information
public class Fibonacci
{
    public static void Main(string[] args)
    {
        int[] result = GetNthFibonacci(10);
        for (int j = 0; j < result.Length; j++) {
            Console.Write("{0} ", result[j]);
        }
    }

    public static int[] GetNthFibonacci(int n)
    {
        int[] fib = new int[n];
        fib[0] = 0;
        fib[1] = 1;
        for (int i = 2; i < n; i++) {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        return fib;
    }
}