using System.ComponentModel.DataAnnotations;

namespace AdvProProject.Data.Models
{
    public class Activities
    {
        [Key]
        public int Id { get; set; }

        public string Game { get; set; }

        public string Talk { get; set; }

        public string Workshop { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters.")]
        public string Description { get; set; }

        public ICollection<Events> Events { get; set; } = new List<Events>();
    }
}
