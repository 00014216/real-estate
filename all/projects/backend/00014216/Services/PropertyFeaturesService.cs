using _00014216.DTOs;
using _00014216.Interfaces;
using _00014216.Models;

namespace _00014216.Services
{
    public class PropertyFeaturesService : IPropertyFeaturesService
    {
        private readonly IPropertyFeaturesRepository _repository;

        public PropertyFeaturesService(IPropertyFeaturesRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<PropertyFeaturesDTO>> GetAllFeaturesByPropertyIdAsync(int propertyId)
        {
            var features = await _repository.GetAllFeaturesByPropertyIdAsync(propertyId);
            return features.Select(f => new PropertyFeaturesDTO
            {
                FeatureID = f.FeatureID,
                PropertyID = f.PropertyID,
                FeatureName = f.FeatureName,
                FeatureValue = f.FeatureValue
            });
        }

        public async Task<PropertyFeaturesDTO> GetFeatureByIdAsync(int featureId)
        {
            var feature = await _repository.GetFeatureByIdAsync(featureId);
            if (feature == null) return null;

            return new PropertyFeaturesDTO
            {
                FeatureID = feature.FeatureID,
                PropertyID = feature.PropertyID,
                FeatureName = feature.FeatureName,
                FeatureValue = feature.FeatureValue
            };
        }

        public async Task AddFeatureAsync(PropertyFeaturesDTO featureDTO)
        {
            var feature = new PropertyFeatures
            {
                PropertyID = featureDTO.PropertyID,
                FeatureName = featureDTO.FeatureName,
                FeatureValue = featureDTO.FeatureValue
            };

            await _repository.AddFeatureAsync(feature);
        }

        public async Task UpdateFeatureAsync(int featureId, PropertyFeaturesDTO featureDTO)
        {
            var feature = await _repository.GetFeatureByIdAsync(featureId);
            if (feature == null) return;

            feature.FeatureName = featureDTO.FeatureName;
            feature.FeatureValue = featureDTO.FeatureValue;

            await _repository.UpdateFeatureAsync(feature);
        }

        public async Task DeleteFeatureAsync(int featureId)
        {
            await _repository.DeleteFeatureAsync(featureId);
        }
    }
}
