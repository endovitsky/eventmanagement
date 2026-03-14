using eventmanagement.Interfaces;
using eventmanagement.Models;

namespace eventmanagement.Services
{
    public class EventService : IEventService
    {
        private List<Event> _events =
        [
            new Event
            {
                Id = Guid.NewGuid(),
                Title = "Test event title 1",
                Description = "Test event description 1",
                StartAt = DateTime.Now.AddDays(14),
                EndAt = DateTime.Now.AddDays(15)
            }
        ];

        public Guid Add(Event @event)
        {
            @event.Id = Guid.NewGuid();
            _events.Add(@event);

            return @event.Id;
        }

        public Guid Delete(Guid id)
        {
            var @event = _events.FirstOrDefault(x => x.Id == id);
            if (@event == null)
            {
                throw new ArgumentException($"Не найдено событие {id}.");
            }

            _events.Remove(@event);

            return @event.Id;
        }

        public IEnumerable<Event> GetAll()
        {
            return _events;
        }

        public Event? GetById(Guid id)
        {
            return _events.FirstOrDefault(x => x.Id == id);
        }

        public Event Update(Event @event)
        {
            var currentEvent = _events.FirstOrDefault(x => x.Id == @event.Id);
            if(currentEvent == null)
            {
                throw new ArgumentException($"Не найдено событие {@event.Id}.");
            }

            currentEvent.Title = @event.Title;
            currentEvent.Description = @event.Description;
            currentEvent.StartAt = @event.StartAt;
            currentEvent.EndAt = @event.EndAt;

            return currentEvent;
        }
    }
}
