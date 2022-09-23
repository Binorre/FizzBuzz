using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracadomowa4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            var fizzBuzz = new FizzBuzz();
            while (true)
            {
                var userInitValue = Console.ReadLine();
                var success = int.TryParse(userInitValue, out int numInt);
                if (!success)
                {
                    Console.WriteLine("Wpisz wartość liczbową");
                    continue;
                }
                Console.WriteLine(fizzBuzz.CheckRemainder(numInt));
            }
        }
    }
}
