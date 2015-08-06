using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Charlatan.Models
{
    [XmlRoot("urlset", Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9")]
    public class Sajtkarta
    {
        [XmlElement("url")]
        public List<Sajtrad> Urler { get; set; }
    }

    public class Sajtrad
    {
        [XmlElement("loc")]
        public string Location { get; set; }
    }
}