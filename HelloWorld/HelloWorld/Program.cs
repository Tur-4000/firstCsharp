using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет МИР!");
            Console.WriteLine("Я хочу изучать C#!");

            Console.WriteLine("Введите два числа");

            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Сумма = " + (a+b));
            Console.WriteLine("Произведение = " + (a * b));
            Console.WriteLine("Среднее арифметическое = " + ((double)(a + b)/2));

            Console.ReadLine();
        }
    }
}
