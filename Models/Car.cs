using System;
using System.ComponentModel.DataAnnotations;

namespace gregslist.Models
{
  public class Car
  {
    public string id { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(15)]
    public string Name { get; set; }
    [Range(0, int.MaxValue)]
    public int Year { get; set; }
    public string Description { get; set; }
    public Car(string name, int age, string description)
    {
      Name = name;
      Age = age;
      Description = description;
      Id = Guid.NewGuid().ToString();
    }
  }
}