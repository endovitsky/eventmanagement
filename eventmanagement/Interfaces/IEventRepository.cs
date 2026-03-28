using eventmanagement.Services.Models;

namespace eventmanagement.Interfaces
{
    public interface IEventRepository
    {
        public IEnumerable<Event> GetAll();
        public Event GetById(Guid id);
        public Guid Add(Event @event);
    }
}
