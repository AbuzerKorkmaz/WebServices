using HomeBi.Libraries.PagedList;
using Microsoft.AspNetCore.Mvc;

using WebApplication1.Models.Entities;

namespace WebApplication1.Controllers
{
    public class KitapController : Controller
    {
        HttpClient client=new HttpClient();
      
        public IActionResult Index()
        {
           var  Kitaps= client.GetFromJsonAsync<List<Kitap>>("https://softwium.com/api/books").Result;
            return View(Kitaps);
        }

        public IActionResult Sayfa()
        {

            var KitapListesi = client.GetFromJsonAsync<List<Kitap>>("https://softwium.com/api/books").Result;
         
            return View(KitapListesi);

           
        }
    }
}
