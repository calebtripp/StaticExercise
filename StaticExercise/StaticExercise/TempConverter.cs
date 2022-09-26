using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double fToC)
        {
            double toCelsius = (fToC - 32) * 5 / 9;
            return toCelsius;
        }
        public static double CelsiusToFahrenheit(double cToF)
        {
            double toFahrenheit = (cToF * 9) / 5 + 32;
            return toFahrenheit;
        }
    }
}
