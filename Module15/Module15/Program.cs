using System;
using System.Linq;

namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<double>();
            while (true)
            {
                var input = double.TryParse(Console.ReadLine(), out double number);
                //var inputList = new List<double>();

                if (!input)
                {
                    Console.WriteLine("Введите число");
                }
                else
                {
                    inputList.Add(number);
                    Console.WriteLine($"Количество чисел: {inputList.Count}\nСумма чисел: {inputList.Sum()}\n" +
                        $"Наибольшее число: {inputList.Max()}\n"+$"Наименьшее число: {inputList.Min()}\nСреднее число:{inputList.Average()}");
                }
            }
        }
    }
}