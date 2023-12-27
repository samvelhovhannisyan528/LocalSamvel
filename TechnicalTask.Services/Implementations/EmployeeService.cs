using TechnicalTask.Domain.Employee;
using TechnicalTask.Entities.Entities;
using TechnicalTask.Entities.Interfaces;
using TechnicalTask.Services.Interfaces;

namespace TechnicalTask.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IBaseRepository<Employee> _repository;

        public EmployeeService(IBaseRepository<Employee> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAsync(AddEmployeeViewModel entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            Employee employee = new Employee()
            {
                FullName = entity.FullName,
                MiddleName = entity.MiddleName,
                Photo = entity.Photo
            };

            var result = await _repository.AddAsync(employee);

            return result;
        }

        public async Task<bool> DeleteAllAsync()
        {
            var result = await _repository.DeleteAllAsync();

            return result;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var model = await _repository.GetByIdAsync(id);

            if (model == null) throw new ArgumentNullException("id");

            var result = await _repository.DeleteByIdAsync(model.Id);

            return result;
        }

        public async Task<List<EmployeeViewModel>> GetAllAsync()
        {
            var models = await _repository.GetAllAsync();
            List<EmployeeViewModel> result = new List<EmployeeViewModel>();

            foreach (var model in models)
            {
                result.Add(new EmployeeViewModel
                {
                    Id = model.Id,
                    FullName = model.FullName,
                    MiddleName = model.MiddleName,
                    Photo = model.Photo,
                });
            }

            return result;
        }

        public async Task<EmployeeViewModel> GetByIdAsync(int id)
        {
            var model = await _repository.GetByIdAsync(id);

            if (model == null) throw new ArgumentNullException("id");

            var result = new EmployeeViewModel()
            {
                Id = model.Id,
                FullName = model.FullName,
                MiddleName = model.MiddleName,
                Photo = model.Photo,
            };

            return result;
        }

        public async Task<bool> UpdateAsync(UpdateEmployeeViewModel entity, int id)
        {
            var model = await _repository.GetByIdAsync(id);

            if (model == null) throw new ArgumentNullException("id");

            var updatedEmployee = new Employee()
            {
                Id = model.Id,
                FullName = entity.FullName,
                MiddleName = entity.MiddleName,
                Photo = entity.Photo
            };

            var result = await _repository.UpdateAsync(updatedEmployee);

            return result;
        }
    }
}
