namespace UnitConverter.Constants
{
    public static class LengthUnits
    {
        public static readonly Dictionary<string, double> ToMeters = new()
        {
            { "m",  1 },
            { "km", 1000 },
            { "cm", 0.01 },
            { "mm", 0.001 },
            { "mi", 1609.344 },
            { "ft", 0.3048 },
            { "in", 0.0254 }
        };
    }
}
