using eventmanagement.Services.Models;

namespace eventmanagement.Services
{
    public static class TestData
    {
        public static List<Event> Data = [
            new Event
            {
                Id = new Guid("a8b0493d-55d4-40b5-8e5f-ffee2e796f13"),
                Title = "Test event title 1",
                Description = "Test event description 1",
                StartAt = DateTime.Now.AddDays(14),
                EndAt = DateTime.Now.AddDays(15)
            },
            new Event
            {
                Id = new Guid("df8a693d-77f8-87b5-8e5f-dead2e796f88"),
                Title = "Test event title 2",
                Description = "Test event description 2",
                StartAt = DateTime.Now.AddDays(14),
                EndAt = DateTime.Now.AddDays(15)
            },
            new Event
            {
                Id = new Guid("f2b8899d-55d4-40b5-8e5f-feaf2e796f13"),
                Title = "Test event title 3",
                Description = "Test event description 3",
                StartAt = DateTime.Now.AddDays(14),
                EndAt = DateTime.Now.AddDays(15)
            }
        ];
    }
}
