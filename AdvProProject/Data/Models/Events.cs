using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdvProProject.Data.Models
{
    public class Events
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Date and Time is required.")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(1000, ErrorMessage = " Description cannot exceed 1000 characters.")]
        public string Description { get; set; }

        //public int? ParticipantId { get; set; }

        //public Participants? Participant { get; set; }
        [JsonIgnore]
        public ICollection<Registration> Registries { get; set; } = new List<Registration>();
        [JsonIgnore]
        public ICollection<Participants> Participants { get; set; } = new List<Participants>();
        public ICollection<Venues> Venues { get; set; } = new List<Venues>();
        public ICollection<Activities> Activities { get; set; } = new List<Activities>();
    }
}
