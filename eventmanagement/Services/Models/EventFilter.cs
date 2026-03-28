namespace eventmanagement.Services.Models
{
    public class EventFilter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Title { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
