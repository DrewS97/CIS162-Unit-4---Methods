using System;

namespace Universe
{

  public class Moon 
  {
    public String Name {get; set;}
    public int CheeseLevel {get; set;}

    public Moon()
    {
      Name = UniverseTools.GetName();

      Random rand = new Random();
      int num = rand.Next(0 , 12);
      CheeseLevel = num;
    }
     public void GetMoon(){
      string moonEmoji = char.ConvertFromUtf32(0x1F31C);
      string cheese = char.ConvertFromUtf32(0x1F9C0);
      string galaxystring = $"\t\t\t{moonEmoji}  {Name} - {cheese}  Cheese Level: {CheeseLevel}.";
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine(galaxystring);
    }

    public override string ToString(){
      string moonEmoji = char.ConvertFromUtf32(0x1F31C);
      string galaxystring = $"\t{moonEmoji}  {Name} - Cheese Level: {CheeseLevel}.";
      return galaxystring;
    }
  }
  
}