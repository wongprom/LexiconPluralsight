﻿namespace WierdBrainCoffee.StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new SimpelStack();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;
            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
            Console.ReadLine();
        }
    }
}
