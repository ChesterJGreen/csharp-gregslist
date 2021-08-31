using System;
using System.ComponentModel.DataAnnotations;

namespace gregslist.Models
{
    public class Job
    {
        public string Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string Name {
            get; set; } 
        public int Pay { get; set; }
        public string Description {get; set; }
        public Job(string name, int pay, string description)
        {
            Name = name;
            Pay = pay;
            Description = description;
            Id = Guid.NewGuid().ToString();
        }
        }
    }
