using TechnicalTask.Domain.Service;
using TechnicalTask.Entities.Entities;
using TechnicalTask.Entities.Interfaces;
using TechnicalTask.Services.Interfaces;

namespace TechnicalTask.Services.Implementations
{
    public class ServiceService : IServiceService
    {
        private readonly IBaseRepository<Service> _repository;

        public ServiceService(IBaseRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAsync(AddServiceViewModel entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            Service service = new Service()
            {
                Name = entity.Name,
                Description = entity.Description,
                Picture = entity.Picture,
            };

            var result = await _repository.AddAsync(service);

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

        public async Task<List<ServiceViewModel>> GetAllAsync()
        {
            var models = await _repository.GetAllAsync();
            List<ServiceViewModel> result = new List<ServiceViewModel>();

            foreach (var model in models)
            {
                result.Add(new ServiceViewModel
                {
                    Id = model.Id,
                    Name = model.Name,
                    Description = model.Description,
                    Picture = model.Picture,
                });
            }

            return result;
        }

        public async Task<ServiceViewModel> GetByIdAsync(int id)
        {
            var model = await _repository.GetByIdAsync(id);

            if (model == null) throw new ArgumentNullException("id");

            var result = new ServiceViewModel()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Picture = model.Picture,
            };

            return result;
        }

        public async Task<bool> UpdateAsync(UpdateServiceViewModel entity, int id)
        {
            var model = await _repository.GetByIdAsync(id);

            if (model == null) throw new ArgumentNullException("id");

            var updatedService = new Service()
            {
                Id = model.Id,
                Name = entity.Name,
                Description = entity.Description,
                Picture = entity.Picture,
            };

            var result = await _repository.UpdateAsync(updatedService);

            return result;
        }
    }
}
