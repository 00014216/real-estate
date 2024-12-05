using _00014216.DTOs;
using _00014216.Interfaces;
using _00014216.Models;
using Microsoft.AspNetCore.Mvc;

namespace _00014216.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        // GET: api/property
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Property>>> GetProperties()
        {
            var properties = await _propertyService.GetAllPropertiesAsync();
            return Ok(properties);
        }

        // GET: api/property/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Property>> GetProperty(int id)
        {
            var property = await _propertyService.GetPropertyByIdAsync(id);
            if (property == null)
            {
                return NotFound();
            }
            return Ok(property);
        }

        // POST: api/property
        [HttpPost]
        public async Task<ActionResult<Property>> PostProperty(Property property)
        {
            await _propertyService.AddPropertyAsync(property);
            return CreatedAtAction(nameof(GetProperty), new { id = property.PropertyID }, property);
        }

        // PUT: api/property/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProperty(int id, Property property)
        {
            if (id != property.PropertyID)
            {
                return BadRequest();
            }
            await _propertyService.UpdatePropertyAsync(property);
            return NoContent();
        }

        // DELETE: api/property/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            await _propertyService.DeletePropertyAsync(id);
            return NoContent();
        }
    }
}
