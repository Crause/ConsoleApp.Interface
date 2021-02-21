using System;
using System.Collections.Generic;

namespace ConsoleApp.Interface
{
  class Program
  {
    static void Main(string[] args)
    {
      var cars = new List<ICar>();
      cars.Add(new MercedesBenzW124());
      cars.Add(new LadaSeven());
      foreach (var car in cars)
      {
        Console.WriteLine(car.Move(400));
      }

      Cyborg cyborg = new Cyborg();
      Console.WriteLine(((IPerson)cyborg).Move(100));
      Console.WriteLine(((ICar)cyborg).Move(100));

      Console.ReadLine();
    }
  }
}
