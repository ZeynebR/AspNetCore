using AspNetCoreEmpty.Models.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var db = new DataContext(); 
            var sizes = db.Sizes.ToList();  
            return Json(sizes);
        }
    }
}
