using _00014216.DTOs;
using _00014216.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _00014216.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropertyFeaturesController : ControllerBase
    {
        private readonly IPropertyFeaturesService _service;

        public PropertyFeaturesController(IPropertyFeaturesService service)
        {
            _service = service;
        }

        [HttpGet("property/{propertyId}")]
        public async Task<IActionResult> GetAllFeaturesByPropertyId(int propertyId)
        {
            var features = await _service.GetAllFeaturesByPropertyIdAsync(propertyId);
            return Ok(features);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeatureById(int id)
        {
            var feature = await _service.GetFeatureByIdAsync(id);
            if (feature == null) return NotFound();
            return Ok(feature);
        }

        [HttpPost]
        public async Task<IActionResult> AddFeature(PropertyFeaturesDTO featureDTO)
        {
            await _service.AddFeatureAsync(featureDTO);
            return CreatedAtAction(nameof(GetFeatureById), new { id = featureDTO.FeatureID }, featureDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFeature(int id, PropertyFeaturesDTO featureDTO)
        {
            await _service.UpdateFeatureAsync(id, featureDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            await _service.DeleteFeatureAsync(id);
            return NoContent();
        }
    }
}
