using TechnicalTask.Domain.Position;

namespace TechnicalTask.Domain.Employee
{
    public class AddEmployeeViewModel
    {
        public string FullName { get; set; }

        public string MiddleName { get; set; }

        public byte[] Photo { get; set; }

        public virtual PositionViewModel Position { get; set; }
    }
}
