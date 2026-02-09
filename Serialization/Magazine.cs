using System;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Magazine
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("release_date")]
        public DateTime ReleaseDate { get; set; }

        [XmlElement("pages")]
        public int Pages { get; set; }

        public Magazine()
        {
            Title = string.Empty;
            Publisher = string.Empty;
            ReleaseDate = DateTime.Now;
            Pages = 0;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Publisher: {Publisher}, Date: {ReleaseDate.ToShortDateString()}, Pages: {Pages}";
        }
    }
}


