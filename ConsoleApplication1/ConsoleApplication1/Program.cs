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

            //Making functions
            //Sum(7, 3);

            //Exception handling
            //String errorMessage;
            //try
            //{
            //    Animal newAnimal = new Animal();
            //    newAnimal.setAge(16);
            //    Console.WriteLine(newAnimal.getAge());
            //}
            //catch(Exception e)
            //{
            //    errorMessage = e.Message;
            //    Console.WriteLine(errorMessage);
            //}
            //How to throw an exception back up the call stack:
            //catch(DivideByZeroException dEx)
            //{
            //    throw new Exception("Division by zero is ont allowed.", dEx.InnerException);
            //}


            
        }

        static void Sum(int first, int second)
        {
            Console.WriteLine(first + second);
        }
    }
    #endregion
}
