namespace TechnicalTask.Entities.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<bool> AddAsync(T entity);

        Task<bool> DeleteByIdAsync(int id);

        Task<bool> DeleteAllAsync();

        Task<bool> UpdateAsync(T entity);
    }
}
