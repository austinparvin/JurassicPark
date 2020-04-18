# Jurassic Park

a simple console application that help manages a zoo full of Dinosaurs. 

## Includes:

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
- MVC design pattern

# Featured Code
## MVC Design pattern
```C#
while (userInput != "q")
{
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("What would you like to do:");
    Console.WriteLine("(VIEW 'v'), (ADD 'a'), (REMOVE 'r'), (TRANSFER 't'), (VIEW ORDERED BY HEAVIEST 'h'), (DIET COUNT 'd'), (QUIT 'q')");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("");
    Console.WriteLine("What would you like to do:");
    userInput = Console.ReadLine();
    Console.WriteLine("");
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
```

## User Actions

- View
- Add
- Remove
- Transfer
- Order By Heaviest
- View Diet Count
- Quit

## App In Action

### ADD
![record it](http://g.recordit.co/7DWFBFXk2r.gif)

### VIEW
![record it](http://g.recordit.co/XFacRTngBP.gif)

### REMOVE
![record it](http://g.recordit.co/cAt6EevvSD.gif)

### TRANSFER
![record it](http://g.recordit.co/rMkr1hQr9s.gif)

### VIEW ORDERED BY HEAVIEST
![record it](http://g.recordit.co/rG6rRECFMG.gif)

### VIEW DIET COUNT
![record it](http://g.recordit.co/6CYWoJ8lIM.gif)

### QUIT
![record it](http://g.recordit.co/am4fLNjed5.gif))
