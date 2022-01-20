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
            Duck rubberDuck = new RubberDuck();
            Duck decoyDuck = new DecoyDuck();

            List<Duck> ducks = new List<Duck> { mallardDuck, 
                redheadDuck, 
                rubberDuck, 
                decoyDuck };
            for (int i = 0; i < ducks.Count; i++)
            {
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].DisPlay());
                if (ducks[i] is IFlyable)
                {
                    Console.WriteLine((ducks[i] as IFlyable).Fly());
                }
                if (ducks[i] is IQuackable)
                {
                    Console.WriteLine((ducks[i] as IQuackable).Quack());
                }
                Console.WriteLine();

            }

              Console.ReadKey();
        }
    }
}

