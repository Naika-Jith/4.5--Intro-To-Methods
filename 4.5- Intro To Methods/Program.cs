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

            //Intro

            Console.Title = "Intro to Methods";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Intro to Methods!");
            Console.WriteLine();
            Console.WriteLine("Please press ENTER to continue");
            Console.ReadLine();
            Console.Clear();



            //TUTORIAL*****************

            Console.WriteLine("Press ENTER for a joke:");
            Console.ReadLine();//Waits for user to press enter to continue
            Joke(); //Calls the Joke method to run the code inside it


            Console.WriteLine("Press ENTER for another joke");
            Console.ReadLine();
            Joke(50);
            //   Notice that when we call this method we need to ‘pass’
            //  it an integer.

            //******************

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

        //ASCII Art

        public static void DrawBear()
        {
            Console.Write(" __         __      ");
            Console.WriteLine("((_,...,_))");

            Console.Write("/  \\.-\"\"\"-./  \\      ");
            Console.WriteLine("  |o o|");

            Console.Write("\\    -   -    /      ");
            Console.WriteLine("  \\   /");

            Console.Write(" |   o   o   |       ");
            Console.WriteLine("   ^_^");

            Console.Write("\\  .-'''-.  /");
            Console.WriteLine();

            Console.Write(" '-\\__Y__/-'");
            Console.WriteLine();

            Console.Write("    `---`");
            Console.WriteLine();
        }

        public static void DrawCat()
        {
            Console.WriteLine("  /\\_/\\  ");
            Console.WriteLine(" ( o.o ) ");
            Console.WriteLine("  > ^ <  ");
        }

        public static void DrawDog()
        {
            Console.WriteLine("  / \\__");
            Console.WriteLine(" (    @\\___");
            Console.WriteLine(" /         O");
            Console.WriteLine("/   (_____/");
            Console.WriteLine("/_____/   U");
        }



    }

}
