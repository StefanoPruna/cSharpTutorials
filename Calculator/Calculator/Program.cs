// See https://aka.ms/new-console-template for more information
//Calculator Program

do
{
    double num1 = 0;
    double num2 = 0;
    double result = 0;
    bool playAgain = true;

    Console.WriteLine("**********");
    Console.WriteLine("Calculator");
    Console.WriteLine("**********");

    Console.WriteLine("Enter number 1:");    
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter number 2:");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter an option:");
    Console.WriteLine("\t+ : Add:");
    Console.WriteLine("\t- : Subtract:");
    Console.WriteLine("\t* : Multiply:");
    Console.WriteLine("\t/ : Divide:");
    Console.WriteLine("\t% : Remainder:");

    //while (Console.ReadLine()!= "+" || Console.ReadLine() != "-" || Console.ReadLine() != "*" || Console.ReadLine() != "/" || Console.ReadLine() != "%")
    //{
    //    Console.WriteLine("Wrong");
    //}  

    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            break;
        case "%":
            result = num1 / num2;
            Console.WriteLine($"Your result: {num1} % {num2} = " + result);
            break;
        default:
            Console.WriteLine("You have not selected the correct symbol");
            break;
    }

    Console.WriteLine("Do you still need the calculator? Y/N"); 
    
} while (Console.ReadLine().ToUpper() == "Y");

Console.WriteLine("Bye!");

