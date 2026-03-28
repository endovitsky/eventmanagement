namespace eventmanagement.Controllers.DtoModels
{
    public class EventFilterDto
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? Title { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
