﻿using TechnicalTask.Domain.Position;
using TechnicalTask.Entities.Entities;
using TechnicalTask.Entities.Interfaces;
using TechnicalTask.Services.Interfaces;

namespace TechnicalTask.Services.Implementations
{
    public class PositionService : IPositionService
    {
        private readonly IBaseRepository<Position> _repository;

        public PositionService(IBaseRepository<Position> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAsync(AddPositionViewModel entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            Position position = new Position()
            {
                Name = entity.Name,
                Description = entity.Description,
                EmployeeId = entity.EmployeeId,
            };

            var result = await _repository.AddAsync(position);

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

        public async Task<List<PositionViewModel>> GetAllAsync()
        {
            var models = await _repository.GetAllAsync();
            List<PositionViewModel> result = new List<PositionViewModel>();

            foreach (var model in models)
            {
                result.Add(new PositionViewModel
                {
                    Id = model.Id,
                    Name = model.Name,
                    Description = model.Description,
                });
            }

            return result;
        }

        public async Task<PositionViewModel> GetByIdAsync(int id)
        {
            var model = await _repository.GetByIdAsync(id);

            if (model == null) throw new ArgumentNullException("id");

            var result = new PositionViewModel()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
            };

            return result;
        }

        public async Task<bool> UpdateAsync(UpdatePositionViewModel entity, int id)
        {
            var model = await _repository.GetByIdAsync(id);

            if (model == null) throw new ArgumentNullException("id");

            var updatedPosition = new Position()
            {
                Id = model.Id,
                Name = entity.Name,
                Description = entity.Description,
                EmployeeId = entity.EmployeeId,
            };

            var result = await _repository.UpdateAsync(updatedPosition);

            return result;
        }
    }
}
