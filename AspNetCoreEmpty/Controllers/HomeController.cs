using AspNetCoreEmpty.Models.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;
        public HomeController(DataContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {

            //var db = new DataContext(); 
            var sizes = db.Sizes.ToList(); 
            var colors =db.Colors.ToList();
            var brands=db.Brands.ToList();
            return Json(sizes);


        }
    }
}
