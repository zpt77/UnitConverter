using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter2
{
    public class WeightConverter : IConverter
    {
        public string Name => "Waga";

        public char Flag => 'd';
        public List<string> Units => new List<string>
        {
            "kg",
            "lb",
            "oz"
        };

        public double Convert(double valueToConvert, string unitFrom, string unitTo)
        {
            switch (unitFrom, unitTo)
            {
                case ("kg", "lb"):
                    valueToConvert = valueToConvert * 2.20462262185;
                    break;
                case ("lb", "kg"):
                    valueToConvert = valueToConvert * 0.45359237;
                    break;
                case ("kg", "oz"):
                    valueToConvert = valueToConvert * 35.2739619;
                    break;
                case ("oz", "kg"):
                    valueToConvert = valueToConvert / 35.2739619;
                    break;
                case ("lb", "oz"):
                    valueToConvert = valueToConvert * 16;
                    break;
                case ("oz", "lb"):
                    valueToConvert = valueToConvert / 16;
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
