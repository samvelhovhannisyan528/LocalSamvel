using TechnicalTask.Domain.Service;

namespace TechnicalTask.Services.Interfaces
{
    public interface IServiceService
    {
        Task<List<ServiceViewModel>> GetAllAsync();

        Task<ServiceViewModel> GetByIdAsync(int id);

        Task<bool> AddAsync(AddServiceViewModel entity);

        Task<bool> DeleteByIdAsync(int id);

        Task<bool> DeleteAllAsync();

        Task<bool> UpdateAsync(UpdateServiceViewModel entity, int id);
    }
}
