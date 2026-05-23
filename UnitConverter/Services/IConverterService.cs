using UnitConverter.Models;

namespace UnitConverter.Services
{
    public interface IConverterService
    {
        double Convert(ConversionRequest request);
    }
}
