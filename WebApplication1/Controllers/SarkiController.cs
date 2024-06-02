using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SarkiController : Controller
    {
        HttpClient client=new HttpClient();
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult SarkiAl()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> SarkiAl(SarkiVM sarkiVM)
        {
           var sarki= await client.GetFromJsonAsync<Lyrics1>($"https://api.lyrics.ovh/v1/{sarkiVM.Sarkici}/{sarkiVM.SarkiAdi}");

            return Content(sarki.Lyrics);
            //return RedirectToAction("SarkiCal",sarki);
        }

        public IActionResult SarkiCal(Lyrics1 lyrics)
        {
            return View(lyrics);
        }

    }
}
