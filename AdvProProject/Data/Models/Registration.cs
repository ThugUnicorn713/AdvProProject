using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AdvProProject.Data.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ParticipantId { get; set; }

        [ForeignKey("ParticipantId")]
        public Participants Participant { get; set; }

        [Required]
        public int EventId { get; set; }

        [ForeignKey("EventId")]
        public Events Event { get; set; }


    }
}
