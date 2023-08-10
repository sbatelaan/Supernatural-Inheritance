using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
        Pupil p = new Pupil("Mezil-kree");

        Storm windStorm = p.CastWindStorm();
        Console.WriteLine(windStorm.Announce());


        Mage m = new Mage("Gul'dan");
        Storm rainStorm = m.CastRainStorm();
        Console.WriteLine(rainStorm.Announce());

        Archmage a = new Archmage("Mielas Aran");
        Storm archMageRainStorm = a.CastRainStorm();
        Storm archMageLightningStorm = a.CastLightningStorm();
        Console.WriteLine(archMageRainStorm.Announce());
        Console.WriteLine(archMageLightningStorm.Announce());
       
    }
  }
}
