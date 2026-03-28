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
            },
            new Event
            {
                Id = new Guid("f2b8777d-33d9-40b5-9f8d-daaa2e531f28"),
                Title = "Birthday party",
                Description = "Birthday event",
                StartAt = DateTime.Now.AddDays(8),
                EndAt = DateTime.Now.AddDays(8).AddHours(4)
            },
            new Event
            {
                Id = new Guid("a3f8903d-15f6-88b5-9f8d-fdaf2e783f03"),
                Title = "St. Petersburg. City day",
                Description = "City day party event",
                StartAt = DateTime.Now.AddDays(18),
                EndAt = DateTime.Now.AddDays(20)
            },
            new Event
            {
                Id = new Guid("a9f8888d-88f8-88b5-8f8d-fdaf2e989f99"),
                Title = "Independence Day",
                Description = "Independence Day event",
                StartAt = DateTime.Now.AddDays(22),
                EndAt = DateTime.Now.AddDays(24)
            },
            new Event
            {
                Id = new Guid("f9a7854d-22a8-22b5-8f8d-aaff2e414f09"),
                Title = "Victory Day",
                Description = "Victory Day event in Moscow",
                StartAt = DateTime.Now.AddMonths(3).AddDays(2),
                EndAt = DateTime.Now.AddMonths(3).AddDays(3)
            },
            new Event
            {
                Id = new Guid("724ef500-b23a-4aee-b0e3-e2ed0c1e4221"),
                Title = "Very new event for test",
                Description = "This is test event",
                StartAt = DateTime.Now.AddMonths(8).AddDays(1),
                EndAt = DateTime.Now.AddMonths(8).AddDays(2)
            },
            new Event
            {
                Id = new Guid("7707ec8a-e188-4283-aee7-d9ce764724d6"),
                Title = "City's new event title",
                Description = "City's new event description",
                StartAt = DateTime.Now.AddMonths(9).AddDays(1),
                EndAt = DateTime.Now.AddMonths(10).AddDays(1)
            },
            new Event
            {
                Id = new Guid("fea127ae-6a71-4d0d-a825-98a40034f216"),
                Title = "День народного единства",
                Description = "Описание события...",
                StartAt = DateTime.Now.AddMonths(3).AddDays(2),
                EndAt = DateTime.Now.AddMonths(3).AddDays(3)
            },
            new Event
            {
                Id = new Guid("f4c84ead-7316-4907-a64a-0083d5b9053f"),
                Title = "Ещё какое-то событие",
                Description = "Описание ещё какого-то события...",
                StartAt = DateTime.Now.AddDays(2),
                EndAt = DateTime.Now.AddDays(3)
            },
            new Event
            {
                Id = new Guid("2ba8ef84-7dd6-4cfb-83b4-e77a1e37f506"),
                Title = "Новое супер событие",
                Description = "Это супер событие...",
                StartAt = DateTime.Now.AddDays(12),
                EndAt = DateTime.Now.AddDays(13)
            }
        ];
    }
}
