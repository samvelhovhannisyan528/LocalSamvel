using System.ComponentModel.DataAnnotations;

namespace TechnicalTask.Entities.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string MiddleName { get; set; }

        public byte[] Photo { get; set; }

        public virtual Position Position { get; set; }
    }
}
