using _00014216.Models;

namespace _00014216.Interfaces
{
    public interface IPropertyFeaturesRepository
    {
        Task<IEnumerable<PropertyFeatures>> GetAllFeaturesByPropertyIdAsync(int propertyId);
        Task<PropertyFeatures> GetFeatureByIdAsync(int featureId);
        Task AddFeatureAsync(PropertyFeatures feature);
        Task UpdateFeatureAsync(PropertyFeatures feature);
        Task DeleteFeatureAsync(int featureId);
    }
}
