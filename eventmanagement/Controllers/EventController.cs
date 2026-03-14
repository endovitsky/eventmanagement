using eventmanagement.Interfaces;
using eventmanagement.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace eventmanagement.Controllers
{
    /// <summary>
    /// Контроллер событий.
    /// </summary>
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

        /// <summary>
        /// Получить событие по id.
        /// </summary>
        /// <param name="id">Id события.</param>
        /// <returns>Событие с указанным Id.</returns>
        [HttpGet("{id}")]
        public ActionResult<List<Event>> GetById(Guid id)
        {
            _logger.LogInformation($"Получение события {id}");
            var result = _eventService.GetById(id);
            _logger.LogInformation($"Результат: {result}");

            return Ok(result);
        }

        /// <summary>
        /// Получить все события.
        /// </summary>
        /// <returns>Список всех событий.</returns>
        [HttpGet]
        public ActionResult<List<Event>> GetAll()
        {
            var result = _eventService.GetAll();
            return Ok(result);
        }

        /// <summary>
        /// Создать новое событие.
        /// </summary>
        /// <param name="event">Данные события.</param>
        /// <returns>Созданное событие.</returns>
        [HttpPost]
        public ActionResult<Guid> Create([FromBody] Event @event)
        {
            var createdId = _eventService.Create(@event);
            return CreatedAtAction(nameof(GetById), new { id = createdId }, @event);
        }

        /// <summary>
        /// Обновить существующее событие.
        /// </summary>
        /// <param name="id">Id события.</param>
        /// <param name="event">Новые данные события.</param>
        /// <returns>Обновлённое событие.</returns>
        [HttpPut("{id}")]
        public ActionResult<Guid> Update(int id, [FromBody] Event @event)
        {
            return Ok(_eventService.Update(@event));
        }

        /// <summary>
        /// Удалить событие.
        /// </summary>
        /// <param name="id">Id события.</param>
        /// <returns>Статус удаления.</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _eventService.Delete(id);
            return NoContent();
        }
    }
}
