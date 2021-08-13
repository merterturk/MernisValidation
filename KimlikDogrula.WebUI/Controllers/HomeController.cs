using KimlikDogrula.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace KimlikDogrula.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Index(Kimlik kimlik)
        {
            if(!ModelState.IsValid)
            {
                return View(kimlik);
            }
            KimlikDogrulaServis.KPSPublicSoapClient client = new KimlikDogrulaServis.KPSPublicSoapClient();
            var result = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(kimlik.TC), kimlik.Ad, kimlik.Soyad, Convert.ToInt32(kimlik.DogumYili));
            TempData["Result"] = result.Body.TCKimlikNoDogrulaResult;
            return RedirectToAction("Sonuc", "Home");
        }
        
        public ActionResult Sonuc()
        {
            return View();
        }

    }
}