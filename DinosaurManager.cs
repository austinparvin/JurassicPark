using System;
using System.Collections.Generic;

namespace JurassicPark
{
  public class DinosaurManager
  {
    public List<Dinosaur> Dinosaurs { get; set; } = new List<Dinosaur>();

    // View
    public void View()
    {
      foreach (var d in Dinosaurs)
      {
        Console.WriteLine("View");
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
      var dino = new Dinosaur()
      {
        Name = name,
        DietType = dietType,
        DateAcquired = dateAcquired,
        Weight = weight,
        EnclosureNumber = enclosureNumber,
      };
      Dinosaurs.Add(dino);

    }
    // Remove
    public void Remove()
    {
      Console.WriteLine("Remove");
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