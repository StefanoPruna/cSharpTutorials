// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Random random = new Random();
bool playAgain = true;
string player;
string computer;
string answer;

while(playAgain)
{
    player = "";
    computer = "";
    answer = "";

    while (player != "rock" && player != "paper" && player != "scissors")
    {
        Console.WriteLine("Enter Rock, Paper, or Scissors: ");
        player = Console.ReadLine();
        //player = player.ToUpper();        
    }

    /*
     * int randomNum = random.Next(1, 7);// 7 is excluded
     * belos is the shorter version
     */
    switch(random.Next(1, 4))
    {
        case 1:
            computer = "Rock";
            break;  
        case 2:
            computer = "Paper";
            break;
        case 3:
            computer = "Scissors";
            break;
    }
    Console.WriteLine("Player: " + player);
    Console.WriteLine("Computer: " + computer);

    switch(player)
    {
        case "rock":
            if (computer == "Scissors")
                Console.WriteLine("The player has won!");
            else if (computer == "paper")
                Console.WriteLine("The computer has won!");
            else
                Console.WriteLine("It's a draw!");

            break;
        case "paper":
            if (computer == "scissors")
                Console.WriteLine("The computer has won!");            
            else if (computer == "rock")
                Console.WriteLine("The player has won!");
            else
                Console.WriteLine("It's a draw!");

            break;
        case "scissors":
            if (computer == "rock")
                Console.WriteLine("The computer has won!");
            else if (computer == "paper")
                Console.WriteLine("The player has won!");
            else if (computer == "scissors")
                Console.WriteLine("It's a draw!");

            break;
        //default:
        //    Console.WriteLine("You have not selected the correct item");
        //    break;            
    }

    Console.WriteLine("would you like to play again? YES/NO");
    answer = Console.ReadLine();
    answer = answer.ToLower();

    if(answer == "yes")
        playAgain = true;
    else
        playAgain = false;
}

Console.WriteLine("****THANKS FOR PLAYING****");
