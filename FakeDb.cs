using System.Collections.Generic;
using gregslist.Models;

namespace gregslist
{
  static public class FakeDB
  {
    static public List<Car> Cars { get; set; } = new List<Car>() { new Car("Honda Accord", 2010, "comes from the plains") };
    static public List<Home> Homes { get; set; } = new List<Home>() { new Home("Victorian", 2015, "2 bed 2 bath 1600 sq. ft.")};
    static public List<Job> Jobs { get; set ; } = new List<Job>() { new Job("Vivint", 50, "software developer position in Utah")};
  }
}