using System;


class Int
{
    public static void divide(int a, int b)
    {
        int q = 0;
        try {
            q = a / b;
        } catch (Exception) {
            Console.WriteLine("Cannot divide by zero");
        } finally {
            Console.WriteLine("{0} / {1} = {2}", a, b, q);
        }
    }
}
