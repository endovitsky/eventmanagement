using eventmanagement.Interfaces;
using eventmanagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace eventmanagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly ILogger _logger;

        public EventController(
            IEventService eventService,
            ILogger<EventController> logger)
        {
            _eventService = eventService;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Event>> GetAllEvents()
        {
            var result = _eventService.GetAll();
            return Ok(result);
        }
    }
}
