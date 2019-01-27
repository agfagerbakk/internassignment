using System;
using System.Globalization;

namespace internassignment
{
    class Speed : IFormattable
    {
        private readonly double MS;
        private const double KN = 0.5399565;

        public Speed(string Speed)
        {
            if (!double.TryParse(Speed, out double speed))
                throw new ArgumentException(nameof(Speed));
            if (speed < 0.0)
                throw new ArgumentOutOfRangeException(nameof(Speed));
            MS = speed;
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format)) format = "KN";
            if (provider == null) provider = CultureInfo.CurrentCulture;

            switch (format)
            {
                case "KN":
                    return (MS * KN).ToString("F2", provider) + " knots";
                case "MS":
                    return MS.ToString("F2", provider) + " KM/H";
                default:
                    throw new FormatException("Invalid formatting: " + format);
            }
        }
    }
}