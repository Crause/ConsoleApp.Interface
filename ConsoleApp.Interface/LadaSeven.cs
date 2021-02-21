using System;

namespace ConsoleApp.Interface
{
  class LadaSeven : ICar
  {
    public void Create()
    {
      throw new NotImplementedException();
    }

    public int Move(int distance)
    {
      return distance / 40;
    }
  }
}
