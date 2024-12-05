using _00014216.Data;
using _00014216.Interfaces;
using _00014216.Models;
using Microsoft.EntityFrameworkCore;

namespace _00014216.Repositories
{
    public class PropertyFeaturesRepository : IPropertyFeaturesRepository
    {
        private readonly RealEstateDbContext _context;

        public PropertyFeaturesRepository(RealEstateDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PropertyFeatures>> GetAllFeaturesByPropertyIdAsync(int propertyId)
        {
            return await _context.Set<PropertyFeatures>()
                .Where(f => f.PropertyID == propertyId)
                .ToListAsync();
        }

        public async Task<PropertyFeatures> GetFeatureByIdAsync(int featureId)
        {
            return await _context.Set<PropertyFeatures>().FindAsync(featureId);
        }

        public async Task AddFeatureAsync(PropertyFeatures feature)
        {
            await _context.Set<PropertyFeatures>().AddAsync(feature);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateFeatureAsync(PropertyFeatures feature)
        {
            _context.Set<PropertyFeatures>().Update(feature);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFeatureAsync(int featureId)
        {
            var feature = await GetFeatureByIdAsync(featureId);
            if (feature != null)
            {
                _context.Set<PropertyFeatures>().Remove(feature);
                await _context.SaveChangesAsync();
            }
        }
    }
}
