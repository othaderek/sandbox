using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.FizzBuzz();
        }

        public void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"FizzBuzz: {i}");
                    continue;
                }

                if (i % 3 == 0)
                {
                    Console.WriteLine($"Fizz: {i}");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine($"Buzz: {i}");
                } else{
                    Console.WriteLine(i);
                }

            }
        }
    }
}
