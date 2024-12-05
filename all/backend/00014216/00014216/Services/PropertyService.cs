using _00014216.DTOs;
using _00014216.Interfaces;
using _00014216.Models;

namespace _00014216.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public async Task<IEnumerable<Property>> GetAllPropertiesAsync()
        {
            return await _propertyRepository.GetAllAsync();
        }

        public async Task<Property> GetPropertyByIdAsync(int id)
        {
            return await _propertyRepository.GetByIdAsync(id);
        }

        public async Task AddPropertyAsync(Property property)
        {
            await _propertyRepository.AddAsync(property);
        }

        public async Task UpdatePropertyAsync(Property property)
        {
            await _propertyRepository.UpdateAsync(property);
        }

        public async Task DeletePropertyAsync(int id)
        {
            await _propertyRepository.DeleteAsync(id);
        }
    }
}

