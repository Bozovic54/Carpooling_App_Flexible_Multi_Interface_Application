using System.ComponentModel.DataAnnotations.Schema;

namespace Carpooling_App.Models { 
   public class Customer
    {
        [Column("customer_id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

        [Column("date_of_birth")]
        public DateOnly DateOfBirth { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("phone_number")]
        public string? PhoneNumber { get; set; }

        [Column("photo")]
        public string? Photo { get; set; } 

        [Column("car")]
        public string? Car { get; set; }

        [Column("experience_level")]
        public string? ExperienceLevel { get; set; }

        [Column("rating")]
        public int? Rating { get; set; }

        [Column("about")]
        public string? About { get; set; }
    }
}
