using System.Collections.Generic;
using gregslist.Models;

namespace gregslist
{
  static public class FakeDB
}
static public List<Car> Cars { get; set; } = new List<Car>() { new Car("Honda Accord", 2010, "comes from the plains") };
}
}