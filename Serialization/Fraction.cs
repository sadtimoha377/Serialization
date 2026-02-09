using System;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Fraction
    {
        [XmlElement("numerator")]
        public int Numerator { get; set; }

        [XmlElement("denominator")]
        public int Denominator { get; set; }

        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
