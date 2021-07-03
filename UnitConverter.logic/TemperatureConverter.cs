using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter2
{
    public class TemperatureConverter : IConverter
    {
        public string Name => "Temperatura";
        public char Flag => 'd';
        public List<string> Units => new List<string>
        {
            "C",
            "F",
            "K"
        };

        public double Convert(double valueToConvert, string unitFrom, string unitTo)
        {
            switch (unitFrom, unitTo)
            {
                case ("C", "F"):
                    valueToConvert = (valueToConvert * 1.8) + 32;
                    break;
                case ("F", "C"):
                    valueToConvert = (valueToConvert - 32) / 1.8;
                    break;
                case ("C", "K"):
                    valueToConvert = valueToConvert + 273.15;
                    break;
                case ("K", "C"):
                    valueToConvert = valueToConvert - 273.15;
                    break;
                case ("F", "K"):
                    valueToConvert = (valueToConvert + 459.67) * 5 / 9;
                    break;
                case ("K", "F"):
                    valueToConvert = valueToConvert * 9 / 5 - 459.67;
                    break;

            }
            return Math.Round(valueToConvert,2);
        }

        public string Convert(string valueToConvert, string unitFrom, string unitTo)
        {
            throw new NotImplementedException();
        }
    }
}
