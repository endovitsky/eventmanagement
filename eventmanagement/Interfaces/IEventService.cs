using eventmanagement.Services.Models;

namespace eventmanagement.Interfaces
{
    public interface IEventService
    {
        Event? GetById(Guid id);
        IEnumerable<Event> GetAll();
        Guid Create(Event @event);
        Event? Update(Guid Id, Event @event);
        Guid? Delete(Guid id);
    }
}
