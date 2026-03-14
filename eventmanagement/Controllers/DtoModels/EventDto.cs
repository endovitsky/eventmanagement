using System.ComponentModel.DataAnnotations;

namespace eventmanagement.Controllers.DtoModels
{
    public class EventDto
    {
        [Required(ErrorMessage = "Заполните название.")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Заполните дату начала.")]
        public DateTime StartAt { get; set; }

        [Required(ErrorMessage = "Заполните дату окончания.")]
        public DateTime EndAt { get; set; }
    }
}
