using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter2
{
   public class VolumeConverter : IConverter
    {
        public string Name => "Objętość";
        public char Flag => 'd';
        public List<string> Units => new List<string>
        {
            "l",
            "US gal",
            "US bbl"
        };

        public double Convert(double valueToConvert, string unitFrom, string unitTo)
        {
           
                switch (unitFrom, unitTo)
                {
                case ("l", "US gal"):
                    valueToConvert = valueToConvert * 0.264172052;
                    break;
                case ("l", "US bbl"):
                    valueToConvert = valueToConvert * 0.0062898;
                    break;
                case ("US gal","l"):
                    valueToConvert = valueToConvert / 0.264172052;
                    break;
                case ("US gal", "US bbl"):
                    valueToConvert = valueToConvert / 42;
                    break;
                case ("US bbl", "l"):
                    valueToConvert = valueToConvert / 0.0062898;
                    break;
                case ("US bbl", "US gal"):
                    valueToConvert = valueToConvert * 42;
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
