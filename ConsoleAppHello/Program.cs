// See https://aka.ms/new-console-template for more information
using ConsoleAppHello;

// new ConsoleAppHello.Initializations().greet();

new Initializations().greet();

// ! Could be used without namespace import
var engine = new MathsCalc();
Points origin = new(1, 2);
var result = engine.Increment(origin.X);

Console.WriteLine("the calculation result is: {0}", result);

// class Program
// {
//   static void Main()
//   {
//     new Initializations().greet();
//   }
// }