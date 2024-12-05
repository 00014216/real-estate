using System.ComponentModel.DataAnnotations;

namespace _00014216.Models
{
    public class PropertyFeatures
    {
        [Key]
        public int FeatureID { get; set; }
        public int PropertyID { get; set; }
        public string FeatureName { get; set; }
        public string FeatureValue { get; set; }

        public Property Property { get; set; }
    }
}
