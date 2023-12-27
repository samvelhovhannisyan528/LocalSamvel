using TechnicalTask.Domain.Position;

namespace TechnicalTask.Services.Interfaces
{
    public interface IPositionService
    {
        Task<List<PositionViewModel>> GetAllAsync();

        Task<PositionViewModel> GetByIdAsync(int id);

        Task<bool> AddAsync(AddPositionViewModel entity);

        Task<bool> DeleteByIdAsync(int id);

        Task<bool> DeleteAllAsync();

        Task<bool> UpdateAsync(UpdatePositionViewModel entity, int id);
    }
}
