using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой твой рост / вес?");
            Console.WriteLine("Рост 150 и <, вес 50 >. Рост 150 и >, вес 50 > роста или <.");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Рост 150 и <, вес 50 >.":
                    Console.WriteLine("Вроде не норм (Вот формула : Рост - 100 = вес, если разница меньше 100, то пора худеть, а если наоборот, то всё норм)");
                    break;

                case "Рост 150 и >, вес 50 > роста или <.":
                    Console.WriteLine("Вроде норм, я не знаю точно, сам думай (Вот формула : Рост - 100 = вес, если разница меньше 100, то пора худеть, а если наоборот, то всё норм)");
                    break;

                case "Не знаю":
                    Console.WriteLine("Подумай ещё");
                    break;

                default:
                    Console.WriteLine("Слыыыш,напиши правильно, а то не понимаю");
                    break;
            }
            Console.ReadLine(); 
        }
    }
}
