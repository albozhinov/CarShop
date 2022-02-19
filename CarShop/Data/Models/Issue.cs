namespace CarShop.Data.Models
{
using System;
using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Issue
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public bool IsFixed { get; set; }

        [Required]
        [MaxLength(36)]
        public string CarId { get; init; }

        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }
    }
}
//•	Has an Id – a string, Primary Key
//•	Has a Description – a string with min length 5 (required)
//•	Has a IsFixed – a bool indicating if the issue has been fixed or not (required)
//•	Has a CarId – a string (required)
//•	Has Car – a Car object
