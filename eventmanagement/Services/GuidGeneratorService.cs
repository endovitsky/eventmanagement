using eventmanagement.Interfaces;

namespace eventmanagement.Services
{
    public class GuidGeneratorService : IGuidGeneratorService
    {
        public Guid Generate()
        {
            return Guid.NewGuid();
        }
    }
}
