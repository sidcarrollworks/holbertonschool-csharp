using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i != j && i < j)
                    {
                        Console.Write("{0}{1}", i, j);
                        if (j != 9 || j - i != 1)
                            Console.Write(", ");
                    }
                }
            }
            Console.Write("\n");
        }
    }
}
