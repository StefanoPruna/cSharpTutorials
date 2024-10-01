// See https://aka.ms/new-console-template for more information

//Conditional operator
/*
double tempC;
string message;
bool tempAgain = true;

while (tempAgain == true)
{
    try
    {
        Console.WriteLine("What's the temperature outside?");
        tempC = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine((tempC <= 0) ? "It's cold outside" : "It's warm outside");
    }
    catch (FormatException e)
    { Console.WriteLine("You have not entered a number"); }

    Console.WriteLine("Do you still want to calculate? Y/N");
    string answer = Convert.ToString(Console.ReadLine());
    answer = answer.ToUpper();
    if (answer == "N")
        tempAgain = false;
}
*/

//Expections if you don't input the correct input
/*
int x;
int y;
double result;
bool playAgain = true;

while (playAgain == true)
{
    try
    {
        Console.WriteLine("Enter the first number :");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        y = Convert.ToInt32
        (Console.ReadLine());

        result = x / y;
        Console.WriteLine("the result is " + result);        
    }
    catch (FormatException e)
    {
        Console.WriteLine("You haven't entered a number");
       
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine("You cannot divide by zero");       
    }
    finally
    {
        //Console.WriteLine("Do you still want to calculate? Y/N");        
    }

    Console.WriteLine("Do you still want to calculate? Y/N");
    string answer = Convert.ToString(Console.ReadLine());
    answer = answer.ToUpper();
    if (answer == "N")
        playAgain = false;
}
*/

//string interpolation
String firstName = "Los";
String lastName = "ke";
Console.WriteLine($"Hello {firstName}{lastName}.");

String[,] parkingLot = { { "Fiat", "Ferrari", "GWM"},
                         {"Lambo", "Toyota", "Something" },
                         {"MG", "AR", "Lancia" }
                       };

parkingLot[1, 3] = "Hybrid";

//foreach ( string pair in parkingLot )
//    Console.WriteLine(pair);

//for(int i=0; i < parkingLot.GetLength(0); i++)
//{
//    for (int j = 0; j < parkingLot.GetLength(1); j++)
//        Console.WriteLine(parkingLot[i, j] + " ");

//    Console.WriteLine();
//}    

