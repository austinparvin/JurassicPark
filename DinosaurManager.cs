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
    public void View()
    {
      // Dinosaurs.Sort((x, y) => DateTime.Compare(x.DateAcquired, y.DateAcquired));
      Console.WriteLine("");
      foreach (var d in Dinosaurs)
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
      Console.WriteLine("Diet Type:");
      var dietType = Console.ReadLine();
      var dateAcquired = DateTime.Now;
      Console.WriteLine("Weight:");
      var weight = int.Parse(Console.ReadLine());
      Console.WriteLine("Encloser Number:");
      var enclosureNumber = int.Parse(Console.ReadLine());

      IDCounter++;

      var dino = new Dinosaur()
      {
        Name = name,
        DietType = dietType,
        DateAcquired = dateAcquired,
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
      View();
      var userInput = int.Parse(Console.ReadLine());

      var dinoToRemove = Dinosaurs.First(dino => dino.ID == userInput);
      Dinosaurs.Remove(dinoToRemove);

    }
    // Transfer
    public void Transfer()
    {
      Console.WriteLine("Transfer");
    }
    // Heaviest
    public void Heaviest()
    {
      Console.WriteLine("Heaviest");
    }
    // Diet Count
    public void DietCount()
    {
      Console.WriteLine("Diet Count");
    }
  }
}