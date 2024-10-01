// See https://aka.ms/new-console-template for more information

//Pass an argument or more to the method

//Method overloading is when the methods share the same name, but
//have different parameters or arguments and signature

//Params is a method parameter that takes a var number of arguments
//The parameter type must be a single dimensional array

using System.ComponentModel.Design;
//string[] description;
//Console.WriteLine("What's your name?");
//string name = Console.ReadLine();

//static string Description(params string[] Description)
//{
//    string[] newDescription;
//    foreach (string s in Description)
//        newDescription;

//    return Console.WriteLine(newDescription);
//}

/*
double total = CheckOut(3.99, 5.75, 15);
Console.WriteLine("Your total to pay is " + total);

static double CheckOut(params double[] prices)
{
    double total = 0;

    foreach(double price in prices)
        total += price;

    return total;
}
*/

/*
double x1;
double y1;
double result;

Console.WriteLine("Enter the 1st number: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the 2nd number: ");
y1 = Convert.ToDouble(Console.ReadLine());

result = Multiply(x1, y1);

Console.WriteLine("The multiplication result between " + x1 + " and " + y1 + " is: " + result);
static double Multiply(double x, double y)
{
    //double z = x * y;
    //return z;
    return x * y;
}
*/

/*
string[] wishes = { "Happy Birthday to you" };
int singing = 0;
while (singing < 3)
{
    foreach (var w in wishes)
        Console.WriteLine(w);
    singing++;
}
*/

/*
string name;
int age;

Console.WriteLine("What's your name?");
name = Console.ReadLine();
Console.WriteLine("What's your age?");
age = Convert.ToInt32(Console.ReadLine());

singing(name, age);

static void singing(string yourName, int yourAge)
{
    Console.WriteLine("Happy Birthday to you");
    Console.WriteLine("Happy Birthday to you");
    Console.WriteLine("Happy Birthday dear " + yourName);
    Console.WriteLine("Happy Birthday to you");
    Console.WriteLine("You are now " + yourAge + " old!");
}
*/

/*
singHappyBirthday();
static void singHappyBirthday()
{
    Console.WriteLine("Happy Birthday to you");
    Console.WriteLine("Happy Birthday to you");
    Console.WriteLine("Happy Birthday dear you");
    Console.WriteLine("Happy Birthday to you");
}
*/