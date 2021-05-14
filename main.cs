using System;
using System.Text;

namespace Universe{

  class MainClass {


    public static void Main (string[] args) {
      
      string turtle = char.ConvertFromUtf32(0x1F422);

      //Creating the Universe
      Universe theUniverse = new Universe();
      Console.WriteLine($"\nThis {turtle} Universe has {theUniverse.Galaxies.Length} galaxies.\n");

      //print galaxies
      foreach(Galaxy g in theUniverse.Galaxies){
        Console.ForegroundColor = ConsoleColor.Magenta;
        g.GetGalaxy();
        Console.ResetColor();
      }
    }
  }  
}    