using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
  public class DinosaurManager
  {
    public List<Dinosaur> Dinosaurs { get; set; } = new List<Dinosaur>();

    public int IDCounter { get; set; } = 0;
    // View
    public void View(List<Dinosaur> list)
    {
      Console.WriteLine("");
      foreach (var d in list)
      {
        Console.WriteLine($"ID:              {d.ID}");
        Console.WriteLine($"Name:            {d.Name}");
        Console.WriteLine($"Diet Type:       {d.DietType}");
        Console.WriteLine($"Date Acquired:   {d.DateAcquired.ToString("dd MMMM HH:mm")}");
        Console.WriteLine($"Weight:          {d.Weight}");
        Console.WriteLine($"Encloser Number: {d.EnclosureNumber}");
        Console.WriteLine("");
      }
    }
    // Add
    public void Add()
    {
      Console.WriteLine("Name:");
      var name = Console.ReadLine();
      Console.WriteLine("Diet Type 'c' for carnivore 'h' for herbavoire:");
      var dietType = Console.ReadLine();
      while (dietType != "h" && dietType != "c")
      {
        Console.WriteLine("I'm sorry, that is not a input.");
        Console.WriteLine("Try Again");
        dietType = Console.ReadLine().ToLower();
      }
      Console.WriteLine("Weight:");
      var weight = int.Parse(Console.ReadLine());
      Console.WriteLine("Encloser Number:");
      var enclosureNumber = int.Parse(Console.ReadLine());

      IDCounter++;

      var dino = new Dinosaur()
      {
        Name = name,
        DietType = dietType,
        Weight = weight,
        EnclosureNumber = enclosureNumber,
        ID = IDCounter
      };

      Dinosaurs.Add(dino);
    }
    // Remove
    public void Remove()
    {
      Console.WriteLine("Which Dinosaur would you like to remove (enter ID#)");
      View(Dinosaurs);
      var userInput = int.Parse(Console.ReadLine());

      var dinoToRemove = Dinosaurs.First(dino => dino.ID == userInput);
      Dinosaurs.Remove(dinoToRemove);

    }
    // Transfer
    public void Transfer()
    {
      Console.WriteLine("Which Dinosaur would you like to Transfer (enter ID#)");
      View(Dinosaurs);

      var IDInput = int.Parse(Console.ReadLine());
      while (!Dinosaurs.Any(item => item.ID == IDInput))
      {
        Console.WriteLine("I'm sorry, that is not a valid input.");
        Console.WriteLine("Try Again");
        IDInput = int.Parse(Console.ReadLine());
        Console.WriteLine(IDInput);
      }

      Console.WriteLine("Which Enclosure Would you like to Tranfer them to?");
      var enclosureInput = int.Parse(Console.ReadLine());

      Dinosaurs.First(dino => dino.ID == IDInput).EnclosureNumber = enclosureInput;
    }
    // Heaviest
    public void Heaviest()
    {
      //this way we preserve data 
      var topThreeHeaviest = Dinosaurs.OrderByDescending(item => item.Weight).Take(3).ToList();
      View(topThreeHeaviest);

    }
    // Diet Count
    public void DietCount()
    {
      var totalHerb = Dinosaurs.Count(item => item.DietType.ToLower() == "h");
      var totalCarn = Dinosaurs.Count(item => item.DietType.ToLower() == "c");
      Console.WriteLine($"Herb: {totalHerb}");
      Console.WriteLine($"Carn: {totalCarn}");
    }
  }
}