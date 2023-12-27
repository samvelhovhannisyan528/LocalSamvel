using TechnicalTask.Domain.Project;

namespace TechnicalTask.Services.Interfaces
{
    public interface IProjectService
    {
        Task<List<ProjectViewModel>> GetAllAsync();

        Task<ProjectViewModel> GetByIdAsync(int id);

        Task<bool> AddAsync(AddProjectViewModel entity);

        Task<bool> DeleteByIdAsync(int id);

        Task<bool> DeleteAllAsync();

        Task<bool> UpdateAsync(UpdateProjectViewModel entity, int id);
    }
}
