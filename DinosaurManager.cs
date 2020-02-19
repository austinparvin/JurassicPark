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
        Console.WriteLine($"{d.Name}");
      }
    }
    // Add
    public void Add()
    {
      Console.WriteLine("Add");
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