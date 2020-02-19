using System;

namespace JurassicPark
{
  class Program
  {
    static void Main(string[] args)
    {
      var d = new DinosaurManager();
      var userInput = "";
      Console.WriteLine("Welcome to Jurassic Park");

      while (userInput != "q")
      {
        Console.WriteLine("What would you like to do:");
        Console.WriteLine("(VIEW 'v'),(ADD 'a'),(REMOVE 'r'),(TRANSFER 't'),(VIEW HEAVIEST 'h'),(DIET COUNT 'd'),(QUIT 'q')");
        userInput = Console.ReadLine();

        switch (userInput)
        {
          case "v":
            d.View(d.Dinosaurs);
            break;
          case "a":
            d.Add();
            break;
          case "r":
            d.Remove();
            break;
          case "t":
            d.Transfer();
            break;
          case "h":
            d.Heaviest();
            break;
          case "d":
            d.DietCount();
            break;
          case "q":
            break;
        }
      }
    }
  }
}
