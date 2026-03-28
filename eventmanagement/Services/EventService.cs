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

        public PaginatedResult<Event> Get(EventFilter eventFilter)
        {
            var events = TestData.Data.Where(x => x.StartAt >= DateTime.Now);

            if(!string.IsNullOrEmpty(eventFilter.Title))
            {
                events = events.Where(x => x.Title.ToLower().Contains(eventFilter.Title.ToLower()));
            }

            if(eventFilter.From.HasValue)
            {
                events = events.Where(x => x.StartAt >= eventFilter.From.Value);
            }

            if(eventFilter.To.HasValue)
            {
                events = events.Where(x => x.EndAt <= eventFilter.To.Value);
            }

            var filteredCount = events.Count();

            var result = events
                .OrderByDescending(c => c.StartAt)
                .Skip((eventFilter.PageNumber - 1) * eventFilter.PageSize)
                .Take(eventFilter.PageSize)
                .ToList();

            int totalPages = (int)Math.Ceiling((double)filteredCount / eventFilter.PageSize);

            return new PaginatedResult<Event>(result, eventFilter.PageNumber, totalPages, filteredCount);
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
