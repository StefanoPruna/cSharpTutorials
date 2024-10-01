// See https://aka.ms/new-console-template for more information

//Class is a bundle of related code
//Object = An instance of a class

using Classes;

Console.WriteLine("What's the name of your car?");
string carName = Console.ReadLine();
Console.WriteLine("What's the make of your car?");
string carId = Console.ReadLine();
Console.WriteLine("What's the model?");
string carModel = Console.ReadLine();
Console.WriteLine("What's the year?");
int carYear = Convert.ToInt32(Console.ReadLine());

Car car1 = new Car(carName, carId, carModel, carYear);
car1.Drive();


/*
Human human1 = new Human();
human1.name = "Loske";
human1.age = 45;
human1.Eat();

Human human2 = new Human();
Console.WriteLine("What's your name?");
human2.name = Console.ReadLine();
Console.WriteLine("What's your age?");
human2.age = Convert.ToInt32(Console.ReadLine());

human2.Sleep(); 
Console.Write("Because " + human2.name + " is " + human2.age + " old"); 
*/


/*You can either create the class file separated and call them below
Messages.Hello();
Messages.Waiting();
Messages.Bye();
//Created the Classes as separated file

//Or create the class in the same file of main
class Messages
{
    void Hello()
    {
        Console.WriteLine("Hello");
    }

    void Waiting()
    {
        Console.WriteLine("Waiting");
    }

    void Bye()
    {
        Console.WriteLine("Bye");
    }
}
*/