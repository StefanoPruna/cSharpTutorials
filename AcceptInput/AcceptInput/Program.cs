// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;

//Console.WriteLine("Please enter your age: ");
//int age = Convert.ToInt32(Console.ReadLine());

//if(age > 100)
//    Console.WriteLine("You'are too old");
//else if (age >= 18 )
//    Console.WriteLine("You are good to go");
//else if(age <=0)
//    Console.WriteLine("You haven't born yet");
//else Console.WriteLine("You are not old enough");

//Console.WriteLine("What's the temperature outside?");
//double temp = Convert.ToDouble(Console.ReadLine());

//if (temp >= 0 && temp <= 10)
//    Console.WriteLine("It's cold");
//else if (temp <= -50 || temp >= 50)
//    Console.WriteLine("Do not go outside");

Console.WriteLine("What's your name?");
string name = Console.ReadLine();

if (name == "")
    Console.WriteLine("You haven't written anything");
else
    Console.WriteLine("Ciao " + name);

