using _00014216.DTOs;

namespace _00014216.Interfaces
{
    public interface IPropertyFeaturesService
    {
        Task<IEnumerable<PropertyFeaturesDTO>> GetAllFeaturesByPropertyIdAsync(int propertyId);
        Task<PropertyFeaturesDTO> GetFeatureByIdAsync(int featureId);
        Task AddFeatureAsync(PropertyFeaturesDTO featureDTO);
        Task UpdateFeatureAsync(int featureId, PropertyFeaturesDTO featureDTO);
        Task DeleteFeatureAsync(int featureId);
    }
}
