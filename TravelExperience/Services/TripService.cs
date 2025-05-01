using TravelExperience.Data;
using TravelExperience.DTOs;
using TravelExperience.Models;

namespace TravelExperience.Services
{
    public class TripService
    {
        private readonly AppDbContext _context;

        public TripService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<TripResponse> CreateTripAsync(TripRequest request)
        {
            if (string.IsNullOrEmpty(request.UserId) || string.IsNullOrEmpty(request.Title))
                throw new ArgumentException("UserId and Title are required");

            var totalCost = request.Activities.Sum(a => a.Cost);

            var trip = new Trip
            {
                UserId = request.UserId,
                Title = request.Title,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                TotalCost = totalCost,
                Activities = request.Activities.Select(a => new Activity
                {
                    DestinationId = a.DestinationId,
                    Duration = a.Duration,
                    Cost = a.Cost
                }).ToList()
            };

            _context.Trips.Add(trip);
            await _context.SaveChangesAsync();

            return new TripResponse
            {
                TripId = trip.TripId,
                Title = trip.Title,
                TotalCost = trip.TotalCost
            };
        }
    }

}
