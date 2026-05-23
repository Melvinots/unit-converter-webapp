using System.ComponentModel.DataAnnotations;

namespace UnitConverter.Models
{
    public class ConversionRequest
    {
        [Required]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Please enter a valid number")]
        public double Value { get; set; }

        [Required]
        public string FromUnit { get; set; } = string.Empty;

        [Required]
        public string ToUnit { get; set; } = string.Empty;

        [Required]
        public string ConversionType { get; set; } = string.Empty;
    }
}
