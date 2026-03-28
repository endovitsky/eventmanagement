using eventmanagement.Interfaces;
using eventmanagement.Services;
using eventmanagement.Services.Models;

namespace eventmanagement.Repositories
{
    public class EventRepository : IEventRepository
    {
        public void Add(Event @event)
        {
            TestData.Data.Add(@event);
        }

        public IEnumerable<Event> GetAll()
        {
            return TestData.Data;
        }

        public Event GetById(Guid id)
        {
            return TestData.Data.FirstOrDefault(x => x.Id == id);
        }
    }
}
