namespace CarShop.Data.Models
{
using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Car
    {
        [Key]
        [StringLength(36)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(20)]
        public string Model { get; init; }

        [Required]
        public int Year { get; init; }

        [Required]
        [StringLength(300)]
        public string PictureUrl { get; set; }

        [Required]
        [StringLength(8)]
        public string PlateNumber { get; init; }

        [Required]
        public string OwnerId { get; init; }

        [ForeignKey(nameof(OwnerId))]
        public User Owner { get; set; }

        public ICollection<Issue> Issues { get; set; } = new List<Issue>();
    }
}
//•	Has an Id – a string, Primary Key
//•	Has a Model – a string with min length 5 and max length 20 (required)
//•	Has a Year – a number (required)
//•	Has a PictureUrl – string (required)
//•	Has a PlateNumber – a string – Must be a valid Plate number (2 Capital English letters, followed by 4 digits, followed by 2 Capital English letters (required)
//•	Has a OwnerId – a string (required)
//•	Has a Owner – a User object
//•	Has Issues collection – an Issue type

