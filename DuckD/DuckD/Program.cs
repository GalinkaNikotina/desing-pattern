using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckD
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();

            Duck[] duck = new Duck[] { mallardDuck, redheadDuck };
            for (int i=0; i<duck.Length; i++)
            {
                Console.WriteLine(duck[i].Quack());
                Console.WriteLine(duck[i].Swim());
                Console.WriteLine(duck[i].DisPlay());
            }

            Console.ReadKey();
        }
    }
}
