using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdvProProject.Data.Models
{
    public class Participants
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        public string Email { get; set; }


        [JsonIgnore]
        public ICollection<Registration> Registries { get; set; } = new List<Registration>();

        [JsonIgnore]
        public ICollection<Events> Events { get; set; } = new List<Events>();

    }
}
