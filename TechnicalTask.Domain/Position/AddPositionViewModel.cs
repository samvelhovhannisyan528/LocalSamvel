using TechnicalTask.Domain.Employee;

namespace TechnicalTask.Domain.Position
{
    public class AddPositionViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int EmployeeId { get; set; }

        public EmployeeViewModel Employee { get; set; }
    }
}
