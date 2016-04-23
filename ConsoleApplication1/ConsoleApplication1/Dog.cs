using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Dog : Animal
    {
        //The override access modifier allows one to overwrite the
        //method from a parent class through Inheritance
        public override void move()
        {
            Console.WriteLine("Flying");
        }
    }
}
