using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Charlatan.Controllers
{
    public class DetailsController : Controller
    {
        private FirebaseService.CharlatanService service = new FirebaseService.CharlatanService();

        public async Task<ActionResult> Index(string name)
        {
            var charlatan = await service.GetCharlatanByName(name);
            if (charlatan == null)
                charlatan = new FirebaseService.Models.Charlatan();
            return View(charlatan);
        }
    }
}