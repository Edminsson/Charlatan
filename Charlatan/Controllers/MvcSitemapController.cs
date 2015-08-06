using Charlatan.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace Charlatan.Controllers
{
    public class MvcSitemapController : Controller
    {
        // GET: MvcSitemap
        public ActionResult Index()
        {
            XmlResult result = new XmlResult(Sajtkarta.GetSajtkarta());

            return result;
        }

    }
}