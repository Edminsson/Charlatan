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

        public static Sajtkarta GetSajtkarta()
        {
            Sajtkarta sajtkarta = new Sajtkarta
            {
                Urler = new List<Sajtrad>
                {
                    new Sajtrad { Location = "http://charlataner.azurewebsites.net/"},
                    new Sajtrad { Location = "http://charlataner.azurewebsites.net/Details/dmnglr"},
                    new Sajtrad { Location = "http://charlataner.azurewebsites.net/Details/sblcvd"}
                }
            };

            return sajtkarta;
        }

    }

    public class Sajtrad
    {
        [XmlElement("loc")]
        public string Location { get; set; }
    }
}