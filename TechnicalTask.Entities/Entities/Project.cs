using System.ComponentModel.DataAnnotations;

namespace TechnicalTask.Entities.Entities
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Url { get; set; }

        public byte[] Picture { get; set; }
    }
}
