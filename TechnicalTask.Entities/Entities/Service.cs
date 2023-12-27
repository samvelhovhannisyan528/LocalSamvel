using System.ComponentModel.DataAnnotations;

namespace TechnicalTask.Entities.Entities
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public byte[] Picture { get; set; }
    }
}
