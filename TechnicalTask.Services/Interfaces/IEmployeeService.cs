using TechnicalTask.Domain.Employee;

namespace TechnicalTask.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeViewModel>> GetAllAsync();

        Task<EmployeeViewModel> GetByIdAsync(int id);

        Task<bool> AddAsync(AddEmployeeViewModel entity);

        Task<bool> DeleteByIdAsync(int id);

        Task<bool> DeleteAllAsync();

        Task<bool> UpdateAsync(UpdateEmployeeViewModel entity, int id);
    }
}
