using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _4._5__Intro_To_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER for a joke:");
            Console.ReadLine();//Waits for user to press enter to continue
            Joke(); //Calls the Joke method to run the code inside it


            Console.WriteLine("Press ENTER for another joke");
            Console.ReadLine();
            Joke(50);

        }

        public static void MethodName()
        {
            //Method code goes here
        }

        public static void Joke()
        {
            Console.WriteLine("99 little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine("99 little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine("100 little bugs in the code.");


            //  If we don’t “call” our method by
            //  referring to its name, we never use it.
            //  In order to actually
            //  use this function, add the following code to your

            //  Main() method:

           // Console.WriteLine("Press ENTER for a joke:");
          //  Console.ReadLine();
          //  Joke(); 

        }

        public static void Joke(int numBugs)
        {
            Console.WriteLine(numBugs + " little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine(numBugs + " little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine((numBugs++) + " little bugs in the code.");

         //  In order to use this method, we must call it. Notice the
         //  difference though; in order to use this
         //method you must provide it with an argument so it knows which
         //version of Jokes() to
         //invoke.

        }









    }
}
