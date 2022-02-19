namespace CarShop.Data.Models
{
using System;
using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(20)]
        public string Username { get; init; }

        [Required]
        [MaxLength(100)]
        public string Email { get; init; }

        [Required]
        [MaxLength(64)]
        public string Password { get; set; }

        public bool IsMechanic { get; set; }
    }
}
//•	Has an Id – a string, Primary Key
//•	Has a Username – a string with min length 4 and max length 20 (required)
//•	Has an Email - a string (required)
//•	Has a Password – a string with min length 5 and max length 20  - hashed in the database (required)
//•	Has а IsMechanic – a bool indicating if the user is a mechanic or a client

