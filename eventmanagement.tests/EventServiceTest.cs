using eventmanagement.Interfaces;
using eventmanagement.Services;
using eventmanagement.Services.Models;
using Moq;

namespace eventmanagement.tests
{
    public class EventServiceTest
    {
        [Fact]
        public void Create_MustCallAllRequiredMethods()
        {
            //Arrange
            var newEvent = new Event() { Title = "test"};

            var mockEventRepository = new Mock<IEventRepository>();
            var mockGuidGeneratorService = new Mock<IGuidGeneratorService>();
            var eventService = new EventService(mockEventRepository.Object, mockGuidGeneratorService.Object);

            //Act
            var result = eventService.Create(newEvent);

            //Assert
            mockGuidGeneratorService.Verify(mockGuidGeneratorService => mockGuidGeneratorService.Generate(), Times.Once);
            mockEventRepository.Verify(repository => repository.Add(newEvent), Times.Once);
        }
    }
}
