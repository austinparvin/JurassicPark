using System;

namespace JurassicPark
{
  class Program
  {
    static void Main(string[] args)
    {
      var d = new DinosaurManager();
      Console.WriteLine("Welcome to Jurassic Park");
      Console.WriteLine("What would you like to do:");
      Console.WriteLine("(VIEW 'v'),(ADD 'a'),(REMOVE 'r'),(TRANSFER 't'),(VIEW HEAVIEST 'h'),(DIET COUNT 'd'),(QUIT 'q')");
      var userInput = Console.ReadLine();

      if (userInput == "v") {
        d.View();
      } else if (userInput == "a") {
        d.Add();  
      } else if (userInput == "r") {
        d.Remove();  
      } else if (userInput == "t") {
        d.Transfer();  
      } else if (userInput == "h") {
        d.Heaviest();  
      } else if (userInput == "d") {
        d.DietCount();  
      } else if (userInput == "q") {
        return;  
      } 
    }
  }
}
