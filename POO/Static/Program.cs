using System;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People pedro = new People()
            {
                Name = "Pedro",
                Age = 1,
            };

            People juan = new People()
            {
                Name = "Juan",
                Age = 13,
            };

            Console.WriteLine(People.Count);

            Console.WriteLine(People.GetCount());

        }

        /// <summary>
        /// Example static on class
        /// </summary>
        public static class A
        {
            public static void Some()
            {
                Console.WriteLine("From Class A");
            }
        }

        public class People
        {
            public static int Count = 0;
            public string Name { get; set; }
            public int Age { get; set; }

            public People()
            {
                Count++;
            }

            public static string GetCount()
            {
                return $"Esta clase se ha utilizado {Count} veces";
            }
        }
    }
}
