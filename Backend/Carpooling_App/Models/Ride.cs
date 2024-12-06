using System.ComponentModel.DataAnnotations.Schema;

namespace Carpooling_App.Models
{
    public class Ride
    {
        [Column("ride_id")]
        public int Id { get; set; }

        [Column("start_location")]
        public string? StartLocation { get; set; }

        [Column("end_location")]
        public string? EndLocation { get; set; }

        [Column("date")]
        public DateOnly Date { get; set; }

        [Column("departure_time")]
        public TimeSpan DepartureTime { get; set; }

        [Column("arrival_time")]
        public TimeSpan ArrivalTime { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("seats_available")]
        public int SeatsAvailable { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
