using System.ComponentModel.DataAnnotations;

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

        //public string Date { get; set; }
        //public float Time { get; set; }
    }
}
