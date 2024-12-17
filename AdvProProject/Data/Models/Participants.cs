using System.ComponentModel.DataAnnotations;

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


    }
}
