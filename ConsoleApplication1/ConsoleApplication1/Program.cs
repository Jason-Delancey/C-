using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    #region temp
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Sum(7, 3);

            //Exception handling
            String errorMessage;
            try
            {
                Animal newAnimal = new Animal();
                newAnimal.setAge(16);
                Console.WriteLine(newAnimal.getAge());
            }
            catch(Exception e)
            {
                errorMessage = e.Message;
                Console.WriteLine(errorMessage);
            }
            
        }

        static void Sum(int first, int second)
        {
            Console.WriteLine(first + second);
        }
    }
    #endregion
}
