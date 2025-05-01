using System.Diagnostics;

namespace TravelExperience.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalCost { get; set; }
        public List<Activity> Activities { get; set; } = new();
    }

}
