using System;

namespace Universe 
{

  public class Planet
  {
    public String Name {get; set;}
    public int Population {get; set;}
    public Moon[] Moons;

    public Planet()
    {
      Name = UniverseTools.GetName();

      Random rand = new Random();
      int num = rand.Next(100000 , 100000000);
      Population = num;

      num = rand.Next(0, 9);
      Moons = new Moon[num];

      for(int i = 0; i < Moons.Length; i++)
      {
        Moons[i] = new Moon();
      }
    }

    public void GetPlanet(){
      string planetEmoji = char.ConvertFromUtf32(0x1F728);
      string moonEmoji = char.ConvertFromUtf32(0x1F31C);
      string populationEmoji = char.ConvertFromUtf32(0x1F46A);
      string galaxystring = $"\t\t{planetEmoji}  {Name} - {populationEmoji} Popluation: {Population} - {moonEmoji} Moons: {Moons.Length}.";
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(galaxystring);
      foreach(Moon moon in Moons){
        moon.GetMoon();
      }
    }

    public override string ToString(){
      string GalaxyEmoji = char.ConvertFromUtf32(0x1f4ab);
      string galaxystring = $"\t{GalaxyEmoji}  {Name} Popluation: {Population}.";
      foreach(Moon moon in Moons){
        galaxystring += "\n"+ moon;
      }
      return galaxystring;
    }
  }
}