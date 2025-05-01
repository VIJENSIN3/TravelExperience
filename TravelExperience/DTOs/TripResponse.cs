namespace TravelExperience.DTOs
{
    public class TripResponse
    {
        public int TripId { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal TotalCost { get; set; }
    }
}
