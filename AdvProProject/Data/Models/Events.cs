using System.ComponentModel.DataAnnotations;

namespace AdvProProject.Data.Models
{
    public class Events
    {
        [Key]

        public string Name { get; set; }
        public string Date { get; set; }
        public float Time { get; set; }
        public string Description { get; set; }


    }
}
