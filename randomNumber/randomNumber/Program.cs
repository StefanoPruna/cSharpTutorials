// See https://aka.ms/new-console-template for more information
Random random = new Random();
bool playAgain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
string response;

while(playAgain)
{
    guess = 0;
    guesses = 0;
    number = random.Next(min, max +1);//101 is exclusive

    Console.WriteLine("**** NUMBER TO GUESS GAME ****\n");

    while (guess != number)
    {
        Console.Write("Guess a number between  " + min + " and " + max + ":\n " );
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess: " + guess + "\n");        

        if (guess != number)
        {
            Console.WriteLine("You guessed it right!\n" + "It took you " + guesses + " guesses!\n");
            break;
        }
        else if (guess < number)
        {
            Console.WriteLine("You didn't guess the number, the number is too low, try again\n");
            //guess += 1;
        }
        else if(guess > number)
        {
            Console.WriteLine("You didn't guess the number, the number is too high, try again\n");
            
        }              

        guesses++;
    }
    Console.WriteLine("Would you like to play again? YES/NO");
    response = Console.ReadLine();
    response = response.ToUpper();

    if(response != "yes") // || response != "YES")
    {
        Console.WriteLine("**** END GAME ****\n");
        playAgain = false;
    }        
    else
        playAgain = true;
}
