using System;

namespace Universe
{

  public class Universe 
  {
    public Galaxy[] Galaxies; 

    public Universe()
    {
      Random rand = new Random();
      int num = rand.Next(2,5);

      Galaxies = new Galaxy[num];
      
      for (int i = 0; i < Galaxies.Length; i++)
      {
        Galaxies[i] = new Galaxy();
      }
    }

    // public Universe(int numGalaxies)
    // {
    //   Galaxies = new Galaxy[numGalaxies];
      
    //   for (int i = 0; i < Galaxies.Length; i++)
    //   {
    //     Galaxies[i] = new Galaxy();
    //   }
    // }
  }
}