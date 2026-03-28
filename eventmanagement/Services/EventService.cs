using eventmanagement.Interfaces;
using eventmanagement.Services.Models;

namespace eventmanagement.Services
{
    public class EventService : IEventService
    {
        public Guid Create(Event @event)
        {
            @event.Id = Guid.NewGuid();
            TestData.Data.Add(@event);

            return @event.Id;
        }

        public Guid? Delete(Guid id)
        {
            var eventToDelete = TestData.Data.FirstOrDefault(x => x.Id == id);
            if (eventToDelete == null)
            {
                return null;
            }

            TestData.Data.Remove(eventToDelete);

            return eventToDelete.Id;
        }

        public PaginatedResult<Event> Get(int pageNumber, int pageSize)
        {
            var events = TestData.Data
                .OrderByDescending(c => c.StartAt)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            int totalPages = (int)Math.Ceiling((double)events.Count / pageSize);

            return new PaginatedResult<Event>(events, pageNumber, totalPages, events.Count);
        }

        public Event? GetById(Guid id)
        {
            return TestData.Data.FirstOrDefault(x => x.Id == id);
        }

        public Event? Update(Guid id, Event @event)
        {
            var eventToUpdate = TestData.Data.FirstOrDefault(x => x.Id == id);
            if(eventToUpdate == null)
            {
                return null;
            }

            eventToUpdate.Title = @event.Title;
            eventToUpdate.Description = @event.Description;
            eventToUpdate.StartAt = @event.StartAt;
            eventToUpdate.EndAt = @event.EndAt;

            return eventToUpdate;
        }
    }
}
