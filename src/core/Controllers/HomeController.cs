using core.Models;
using Microsoft.AspNetCore.Mvc;

namespace core.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var model = new Resturant
            {
                Id = 1,
                Name = "Sabatinio's"
            };
           return View(model);
        }
    }
}
