using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace UnitConverter.logic.Model
{
    public class Statistics
    {
        public int ID { get; set; }
        public string Measure { get; set; }
        public string InputUnit { get; set; }
        public string OutputUnit { get; set; }
        public string Value { get; set; }
        public string Output { get; set; }
        public DateTime ConversionDate {get; set;}

    }
}
