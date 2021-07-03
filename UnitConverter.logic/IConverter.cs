using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter2
{
   public interface IConverter
    {
        public String Name { get; }
        
        public char Flag { get; }
        public List<string> Units { get; }
        public double Convert(double valueToConvert, String unitFrom, String unitTo);

        public String Convert(String valueToConvert, String unitFrom, String unitTo);

    }
}
