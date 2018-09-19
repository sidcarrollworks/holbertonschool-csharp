using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string holberton = "NOTREBLOH";
        Stack<char> stack = new Stack<char>();

        foreach (char x in holberton) {
            stack.Push(x);
            Console.Write(x);
        }
        Console.WriteLine();
        
        Console.Write(stack.Pop());
        
    }
}
