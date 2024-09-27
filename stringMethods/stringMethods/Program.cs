// See https://aka.ms/new-console-template for more information
string phoneNumber = "123-456-789";
phoneNumber = phoneNumber.Replace("-", "/");

string fullName = "Loske";
string userName = fullName.Insert(0, "Mr.");

Console.WriteLine(fullName.Length);

string firstName = fullName.Substring(0, fullName.Length - 1);
string nextLine = fullName.Substring(3, 2);//print the last two characters
Console.WriteLine(nextLine);

