using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Animal
    {

        private String type, color, weight, height;
        private int age, numOfLegs;

        //The 'virtual' access modifier allows a method to be overwritten in a child
        //class, through Inheritance

        public void setAge(int aAge)
        {
            age = aAge;
        }

        public int getAge()
        {
            return age;
        }

        public virtual void move()
        {
            Console.WriteLine("Moved");
        }

        public virtual void makeNoise()
        {
            Console.WriteLine("Made some noise");
        }
    }
}
