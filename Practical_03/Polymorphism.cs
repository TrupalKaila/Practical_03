using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03
{
    //Bird class with Voice method and it is with virtual keyword - it means that voice method might get overidden
    public class Bird
    {
        public virtual void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }
    //Duck class is created and also inherit bird class
    public class Duck : Bird
    {
        //Voice method overrides as it is already defined in Bird class
        public override void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }

}
