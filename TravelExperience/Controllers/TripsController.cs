using Microsoft.AspNetCore.Mvc;
using TravelExperience.DTOs;
using TravelExperience.Services;

namespace TravelExperience.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TripsController : ControllerBase
    {
        private readonly TripService _tripService;

        public TripsController(TripService tripService)
        {
            _tripService = tripService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrip([FromBody] TripRequest request)
        {
            try
            {
                var response = await _tripService.CreateTripAsync(request);
                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "An error occurred while creating the trip." });
            }
        }
    }

}
