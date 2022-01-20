using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckD
{
    public class RedheadDuck: Duck
    {
        public override string DisPlay()
        {
            return "DisPlay1" + " " + this.GetType();
        }
    }
}
