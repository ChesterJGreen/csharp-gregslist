using System.ComponentModel.DataAnnotations;
using System;

namespace gregslist.Models
{
  public class Car
  {
    public string Id { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(15)]
    public string Name { get; set; }
    [Range(0, int.MaxValue)]
    public int Year { get; set; }
    public string Description { get; set; }
    public Car(string name, int year, string description)
    {
      Name = name;
      Year = year;
      Description = description;
      Id = Guid.NewGuid().ToString();
    }
  }
}