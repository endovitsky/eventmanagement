using eventmanagement.Validators;
using System.ComponentModel.DataAnnotations;

namespace eventmanagement.Controllers.DtoModels
{
    /// <summary>
    /// Событие. Объект передачи данных.
    /// </summary>
    public class EventDto
    {
        /// <summary>
        /// Название.
        /// </summary>
        [Required(ErrorMessage = "Заполните название.")]
        public string Title { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Дата начала.
        /// </summary>
        [Required(ErrorMessage = "Заполните дату начала.")]
        public DateTime StartAt { get; set; }

        /// <summary>
        /// Дата окончания.
        /// </summary>
        [Required(ErrorMessage = "Заполните дату окончания.")]
        [DateGreaterThan(nameof(StartAt))]
        public DateTime EndAt { get; set; }
    }
}
