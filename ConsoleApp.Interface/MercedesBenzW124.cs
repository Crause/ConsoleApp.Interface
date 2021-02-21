using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interface
{
  class MercedesBenzW124 : ICar
  {
    public void Create()
    {
      throw new NotImplementedException();
    }

    public int Move(int distance)
    {
      return distance / 100;
    }
  }
}
