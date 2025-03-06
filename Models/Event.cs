using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }

        public int Participants { get; set; }
    }
}
