using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter2
{
    public class TimeConverter : IConverter
    {
        public string Name => "Czas";
        public char Flag => 's';
        public List<string> Units => new List<string>
        {
            "24h"
            ,"12h"
        };

        public string Convert(string valueToConvert, string unitFrom, string unitTo)
        {
            int hours, minutes;
            hours = System.Convert.ToInt32(valueToConvert.Substring(0,2));
            minutes = System.Convert.ToInt32(valueToConvert.Substring(3, 2));
            switch (unitFrom, unitTo)
            {
                case ("24h", "12h"):
                    if(hours < 12)
                    {
                        valueToConvert = valueToConvert + "AM";
                    } else
                    {
                        hours = hours - 12;
                        valueToConvert = hours.ToString() + ":" + minutes.ToString() + "PM";
                    }
                    break;
                case ("12h", "24h"):
                    String meridiem = valueToConvert.Substring(5, 2);
                    if(meridiem == "AM")
                    {
                        valueToConvert = valueToConvert.Substring(0, 4);
                    } else
                    {
                        hours = hours + 12;
                        valueToConvert = hours.ToString() + ":" + minutes.ToString();
                    }
                    break;
            }
            return valueToConvert;
        }

        public double Convert(double valueToConvert, string unitFrom, string unitTo)
        {
            throw new NotImplementedException();
        }
    }
}
