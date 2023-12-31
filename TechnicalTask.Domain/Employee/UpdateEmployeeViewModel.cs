﻿using TechnicalTask.Domain.Position;

namespace TechnicalTask.Domain.Employee
{
    public class UpdateEmployeeViewModel
    {
        public string FullName { get; set; }

        public string MiddleName { get; set; }

        public byte[] Photo { get; set; }

        public PositionViewModel Position { get; set; }
    }
}
