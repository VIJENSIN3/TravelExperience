namespace TravelExperience.DTOs
{
    public class TripRequest
    {
        public string UserId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<ActivityDto>? Activities { get; set; }
        public class ActivityDto
        {
            public int DestinationId { get; set; }
            public int Duration { get; set; }
            public decimal Cost { get; set; }
        }
    }
}
