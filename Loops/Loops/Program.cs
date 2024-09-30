// See https://aka.ms/new-console-template for more information

//Console.Write will print in the same row/line, while WriteLine uses different lines/rows
/*Nested loop
 */
Console.Write("How many rows?\n");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many columns?");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("What symbol: \n");
string symbol = Console.ReadLine();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        Console.Write(symbol);

    Console.WriteLine();
}
    

/*For loop
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("The loop is going");
    if (i == 4) Console.WriteLine("The loop is over");
}
//Either inside or outside and it'll print it at the end
Console.WriteLine("The loop is over");
*/

/*While loop
string name = "";

while (name == "")
{
    Console.Write("What's your name?\n");
    name = Console.ReadLine();
}
*/

//double remainder = 3 % 2;
//Console.WriteLine(remainder);

Console.ReadKey();
