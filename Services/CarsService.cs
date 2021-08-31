using System;
using System.Collections.Generic;
using gregslist.Models;

namespace gregslist.Services
{
  public class CarsService
  {
    internal IEnumerable<Car> Get()
    {
      return FakeDB.Cars;
    }
    internal Car Get(string id)
    {
      Car found = FakeDB.Cars.Find(csharp_gregslist => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }
    internal Car Create(Car newCar)
    {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }
    internal void Delete(string id)
    {
      int deleted = FakeDB.Cars.RemoveAll(Car => csharp_gregslist.Id == id);
      if (deleted == 0)
      {
        throw new Exception("Invalid Id");
      }
    }
  }
}