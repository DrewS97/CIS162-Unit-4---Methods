using System;

namespace Universe
{

  public class Star 
  {
    public String Name {get; set;}
    public String Color {get; set;}
    public Planet[] Planets;
    
    //constructor method
    public Star()
    {
      Name = UniverseTools.GetName();
      GenerateColor();

      Random rand = new Random();
      int num = rand.Next(2,5);

      Planets = new Planet[num];

      for(int i = 0; i < Planets.Length; i++)
      {
        Planets[i] = new Planet();
      }
    }
    //overloaded constructor method

    public void GenerateColor(){
      Random rand = new Random();
      string[] color = { "Yellow", "Blue", "Red", "White"};
      Color = color[rand.Next(color.Length)];
    }
  
    public void GetStar(){
      // Determining printed color of star
      if (Color == "Yellow"){
        Console.ForegroundColor = ConsoleColor.Yellow;
      }
      else if (Color == "Blue"){
        Console.ForegroundColor = ConsoleColor.Blue;
      }
      else if (Color == "Red"){
        Console.ForegroundColor = ConsoleColor.Red;
      }
      else if (Color == "White"){
        Console.ForegroundColor = ConsoleColor.White;
      }
      else{
        Console.ForegroundColor = ConsoleColor.White;
      }
    
      string StarEmoji = char.ConvertFromUtf32(0x1f31f);
      string galaxystring = $"\t{StarEmoji}  {Name} - {Color} - Planets: {Planets.Length}";
      Console.WriteLine(galaxystring);
      foreach(Planet planet in Planets){
        planet.GetPlanet();
      }
      Console.ResetColor();
    }

    public override string ToString(){
      string GalaxyEmoji = char.ConvertFromUtf32(0x1f4ab);
      string galaxystring = $"\t{GalaxyEmoji}  {Name} is a {Color} star.";
      foreach(Planet planet in Planets){
        galaxystring += "\n"+ planet;
      }
      return galaxystring;
    }
  }
}
  

