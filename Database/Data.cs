using System.Collections.Generic;
using catFarm.Models;

namespace catFarm.Database
{
  public static class Data
  {
    public static List<Cat> CatData = new List<Cat>()
    {
      new Cat(1, "Fluffy", 7, false),
      new Cat(2, "Frank", 12, true),
      new Cat(3, "Lucifer", 5219, true)
    };
  }
}