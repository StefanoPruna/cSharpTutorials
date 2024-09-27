// See https://aka.ms/new-console-template for more information
//Math functions

//double x = 3.99;
//double y = 5;

//double a = Math.Pow(x, 3);
//double b = Math.Sqrt(x);
//double c = Math.Abs(y);
//double d = Math.Round(a);
//double e = Math.Ceiling(b);
//double f = Math.Floor(c);
//double g = Math.Max(d, y);
//double h = Math.Min(e, x);

Console.WriteLine(h);

//Find the hypotenuse of a triangle
Console.WriteLine("Enter side A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter side B: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt((a * a) + (b * b));
Console.WriteLine("The hypotenuse is : " + c);
