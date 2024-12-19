using System.ComponentModel.DataAnnotations;

namespace AdvProProject.Data.Models
{
    public class Venues
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(1000, ErrorMessage = "Address cannot exceed 1000 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Capacity is required.")]
        public int Capacity { get; set; }

        public int? EventId { get; set; }

        public Events? Event { get; set; }
    }
}
