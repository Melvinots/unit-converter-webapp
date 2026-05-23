namespace UnitConverter.Constants
{
    public static class WeightUnits
    {
        public static readonly Dictionary<string, double> ToKilograms = new()
        {
            { "kg", 1 },
            { "g",  0.001 },
            { "mg", 0.000001 },
            { "lb", 0.453592 },
            { "oz", 0.0283495 },
            { "t",  1000 }
        };
    }
}
