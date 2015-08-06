﻿using Charlatan.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Xml.Serialization;

namespace Charlatan.Controllers
{
    public class SitemapController : ApiController
    {
        public HttpResponseMessage Get()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(SerialiseraSajtkarta(getSajtkarta()), Encoding.UTF8);
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/xml");
            return response;
        }

        private string SerialiseraSajtkarta(Sajtkarta sajtkarta)
        {
            XmlSerializer srlr = new XmlSerializer(typeof(Sajtkarta));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, "http://www.sitemaps.org/schemas/sitemap/0.9");

            MemoryStream ms = new MemoryStream();
            srlr.Serialize(ms, sajtkarta, ns);

            return Encoding.UTF8.GetString(ms.ToArray());
        }

        private Sajtkarta getSajtkarta()
        {
            Sajtkarta sajtkarta = new Sajtkarta
            {
                Urler = new List<Sajtrad>
                {
                    new Sajtrad { Location = "http://charlataner.azurewebsites.net/"},
                    new Sajtrad { Location = "http://charlataner.azurewebsites.net/Details/dmnglr"}
                }
            };

            return sajtkarta;
        }
    }
}