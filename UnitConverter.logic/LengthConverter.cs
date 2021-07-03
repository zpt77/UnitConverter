using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter2
{
   public class LengthConverter : IConverter
    {
        public string Name => "Długość";
        public char Flag => 'd';
        public List<string> Units => new List<string>
        {
            "mi",
            "km",
            "y"
        };

        public double Convert(double valueToConvert, string unitFrom, string unitTo)
        {
            switch (unitFrom, unitTo)
            { 
                case ("mi", "km"):
                    valueToConvert = valueToConvert * 1.609344;
                    break;
                case ("km", "mi"):
                    valueToConvert = valueToConvert / 1.609344;
                    break;
                case ("km", "y"):
                    valueToConvert = valueToConvert * 1093.6133;
                    break;
                case ("y", "km"):
                    valueToConvert = valueToConvert / 1093.6133;
                    break;
                case ("mi", "y"):
                    valueToConvert = valueToConvert * 1760;
                    break;
                case ("y", "mi"):
                    valueToConvert = valueToConvert / 1760;
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
