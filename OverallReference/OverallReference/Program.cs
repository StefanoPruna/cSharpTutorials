using System;

//Console.WriteLine("Hello, World!");

namespace Overallreference
{
    class Program
    {
        static void Main(string[] args)
        {
            /*type casting = Converting a value to a different data type
             * */
            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine(b.GetType());//it prints the data type of the var
            int c = 253;
            double d = Convert.ToInt32(c) + 0.1;
            Console.WriteLine(d);
            string f = "125";
            int g = Convert.ToInt32(f) + 5;
            Console.WriteLine(g);

            /*constant             
            const double pie = 3.14159;
            */

            /*
            //declare and initialise variable types
            int x;//declaration
            x = 123;//initialisation
            int y = 431;
            double height = 300.5;
            Console.WriteLine("Your height is " + height + " cm");
            bool alive = true;
            Console.WriteLine("Are you alive?\n" + alive);
            char symbol = '@';
            string name = "Loske";
            Console.WriteLine("Hello, \t" + symbol + name);//t for Tab space
            //Console.WriteLine("Hello\n, World!");            
            */

            Console.ReadKey();
        }
    }
}

