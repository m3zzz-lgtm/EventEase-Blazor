using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Event name is required")]
        [StringLength(50, ErrorMessage = "Name is too long")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; } = string.Empty;

        public DateTime Date { get; set; } = DateTime.Today;

        public int AttendeesCount { get; set; } = 0;
    }
}
