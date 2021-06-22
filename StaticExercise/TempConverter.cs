using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelsius(double farenheit)
        {
            var result = (farenheit - 32) / 1.8;

            return result;
        }

        public static double CelciusToFarenheit(double celcius)
        {
            return (celcius * 9) / 5 + 32;
        }
    }

}
