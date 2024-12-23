using System.ComponentModel.DataAnnotations;

namespace AdvProProject.Data.Models
{
    public class EventsDTO
    {
        //trying to avoid recursion error in blazer
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Date and Time is required.")]
        public DateTime DateTime { get; set; }
        public string? Venue { get; set; }
        public string? Activity { get; set; }
    }
}
