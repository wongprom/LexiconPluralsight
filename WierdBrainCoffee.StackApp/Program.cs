
namespace WierdBrainCoffee.StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackDoublesd();
            StackStrings();
            Console.ReadLine();
        }


        private static void StackDoublesd()
        {
            var stack = new Stack<double>();
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
        }
        private static void StackStrings()
        {
            var stack = new Stack<string>();
            stack.Push("Some string");
            stack.Push("PluralSight");

            while (stack.Count > 0)
            {
                Console.WriteLine(  stack.Pop());
            }
        }
    }
}
