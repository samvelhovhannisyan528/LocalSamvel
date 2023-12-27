using TechnicalTask.Domain.Position;

namespace TechnicalTask.Domain.Employee
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string MiddleName { get; set; }

        public byte[] Photo { get; set; }

        public PositionViewModel Position { get; set; }
    }
}
