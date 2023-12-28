using System.ComponentModel.DataAnnotations;

namespace TechnicalTask.Entities.Entities
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
