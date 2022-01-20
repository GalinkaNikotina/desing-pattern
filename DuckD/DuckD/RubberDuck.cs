using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckD
{
    public class RubberDuck: Duck, IQuackable
    {
        public override string DisPlay()
        {
            return "DisPlay" + " " + this.GetType();
        }
        public string Quack()
        {
            return "Quackable" + " " + this.GetType();
        }
    }
}
