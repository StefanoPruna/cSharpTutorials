// See https://aka.ms/new-console-template for more information

//string[] macchine =  new string[3];
string[] cars = { "FIAT", "GWM", "FERRARI" };

//Console.WriteLine(cars[0]);
//Console.WriteLine(cars[1]);
Console.WriteLine(cars[2]);

cars[2] = "Lamborghini";
for ( int i = 0; i < cars.Length; i++ )
    Console.WriteLine(cars[i]);
