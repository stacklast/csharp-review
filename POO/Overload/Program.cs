using System;

namespace Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.Sum(2, 3));
            Console.WriteLine(math.Sum("1", "2"));

            int[] numbers = new int[] { 1, 2, 5 };
            Console.WriteLine(math.Sum(numbers));
        }
    }

    public class Math
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        //overload
        public int Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        //overload
        public int Sum(int[] numbers)
        {
            int result = 0;
            int i = 0;

            while (i < numbers.Length)
            {
                result += numbers[i];
                i++;
            }

            return result;
        }
    }
}
