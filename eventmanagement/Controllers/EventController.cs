using eventmanagement.Controllers.DtoModels;
using eventmanagement.Interfaces;
using eventmanagement.Services.Models;
using Microsoft.AspNetCore.Http.HttpResults;
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
        public ActionResult<Event> GetById(Guid id)
        {
            _logger.LogInformation($"Получение события {id}");

            var result = _eventService.GetById(id);
            if(result == null)
            {
                var notFoundMsg = $"Не найдно событие {id}.";
                _logger.LogError(notFoundMsg);

                return NotFound(notFoundMsg);
            }

            _logger.LogInformation($"Найдено событие {result}.");
            
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
        /// <param name="eventDto">Данные события.</param>
        /// <returns>Созданное событие.</returns>
        [HttpPost]
        public ActionResult<Guid> Create([FromBody] EventDto eventDto)
        {
            if(!TryValidateModel(eventDto))
            {
                return BadRequest(ModelState);
            }

            var eventToCreate = new Event
            {
                Title = eventDto.Title,
                Description = eventDto.Description,
                StartAt = eventDto.StartAt,
                EndAt = eventDto.EndAt
            };

            var createdId = _eventService.Create(eventToCreate);
            return CreatedAtAction(nameof(GetById), new { id = createdId }, eventDto);
        }

        /// <summary>
        /// Обновить существующее событие.
        /// </summary>
        /// <param name="id">Id события.</param>
        /// <param name="eventDto">Новые данные события.</param>
        /// <returns>Обновлённое событие.</returns>
        [HttpPut("{id}")]
        public ActionResult<Guid> Update(Guid id, [FromBody] EventDto eventDto)
        {
            if(!TryValidateModel(eventDto))
            {
                return BadRequest(ModelState);
            }

            var @event = new Event
            {
                Title = eventDto.Title,
                Description = eventDto.Description,
                StartAt = eventDto.StartAt,
                EndAt = eventDto.EndAt
            };

            var result = _eventService.Update(id, @event);
            if(result == null)
            {
                return NotFound($"Не найдено событие {id}.");
            }

            return Ok(result);
        }

        /// <summary>
        /// Удалить событие.
        /// </summary>
        /// <param name="id">Id события.</param>
        /// <returns>Статус удаления.</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var result = _eventService.Delete(id);
            if(result == null)
            {
                return NotFound($"Не найдено событие {id}.");
            }

            return NoContent();
        }
    }
}
