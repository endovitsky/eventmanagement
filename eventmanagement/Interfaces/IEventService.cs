using eventmanagement.Services.Models;

namespace eventmanagement.Interfaces
{
    public interface IEventService
    {
        Event? GetById(Guid id);
        PaginatedResult<Event> Get(int pageNumber, int pageSize);
        Guid Create(Event @event);
        Event? Update(Guid Id, Event @event);
        Guid? Delete(Guid id);
    }
}
