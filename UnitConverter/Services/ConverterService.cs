using UnitConverter.Models;

namespace UnitConverter.Services
{
    public class ConverterService : IConverterService
    {
        public double Convert(ConversionRequest request) => request.ConversionType switch
        {
            "length" => ConvertLength(request.Value, request.FromUnit, request.ToUnit),
            "weight" => ConvertWeight(request.Value, request.FromUnit, request.ToUnit),
            "temperature" => ConvertTemperature(request.Value, request.FromUnit, request.ToUnit),
            _ => throw new ArgumentException("Unknown conversion type")
        };

        private double ConvertLength(double val, string from, string to)
        {
            var meters = val * Constants.LengthUnits.ToMeters[from];
            return meters / Constants.LengthUnits.ToMeters[to];
        }

        private double ConvertWeight(double val, string from, string to)
        {
            var kg = val * Constants.WeightUnits.ToKilograms[from];
            return kg / Constants.WeightUnits.ToKilograms[to];
        }

        private double ConvertTemperature(double val, string from, string to)
        {
            var celsius = from switch
            {
                "C" => val,
                "F" => (val - 32) * 5.0/9.0,
                "K" => val - 273.15,
                _ => throw new ArgumentException("Unknown temperature unit")
            };

            var result = to switch
            {
                "C" => celsius,
                "F" => (celsius * 9.0/5.0) + 32,
                "K" => celsius + 273.15,
                _ => throw new ArgumentException("Unknown temperature unit")
            };

            return result;
        }
    }
}
