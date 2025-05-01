namespace TravelExperience.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public int DestinationId { get; set; }
        public int Duration { get; set; }
        public decimal Cost { get; set; }
        public int TripId { get; set; }
        public Trip? Trip { get; set; }
    }

}
