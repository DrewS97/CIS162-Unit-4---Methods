using System;
using System.Text;

namespace Universe
{


  public static class UniverseTools
  {
    //you can use this method to help generate a random name
    public static char GetCharacter()
    {
      string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
      Random rand = new Random();
      int num = rand.Next(0, chars.Length -1);
      return chars[num];
    }
    
    //use the GetCharacter method in the method below to create a random name
    public static string GetName()
    {
      string name = "";
      //generate a random name here using a loop
      for(int n = 0; n < 8; n++)
      {
        name += GetCharacter();
      }
      return name;
    }
  }
}