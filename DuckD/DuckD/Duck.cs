using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckD
{
    public abstract class Duck
    {
        public string Quack()
        {
            return "Quack" + " " + this.GetType();
        }
        public string Swim()
        {
            return "Swim" + " " + this.GetType();
        }
        abstract public string DisPlay();
    }
}
