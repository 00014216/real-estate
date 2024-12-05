using _00014216.DTOs;
using _00014216.Models;

namespace _00014216.Interfaces
{
    public interface IPropertyService
    {
        Task<IEnumerable<Property>> GetAllPropertiesAsync();
        Task<Property> GetPropertyByIdAsync(int id);
        Task AddPropertyAsync(Property property);
        Task UpdatePropertyAsync(Property property);
        Task DeletePropertyAsync(int id);
    }
}
