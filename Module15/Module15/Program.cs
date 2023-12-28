using System;

namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            static long Factorial(int number)
            {
                var numbers = new List<int>();

                for (int i = 1; i <= number; i++)
                    numbers.Add(i);

                return numbers.Aggregate((x, y) => x * y);
            }

            var result1 = Factorial(1);
            var result2 = Factorial(2);
            var result3 = Factorial(3);
            Console.WriteLine($"Первый результат: {result1}\nВторой результат: {result2}\nТретий результат: {result3}");
        }
    }
}