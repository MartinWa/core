using core.Models;
using core.Services;
using Microsoft.AspNetCore.Mvc;

namespace core.Controllers
{
    public class HomeController : Controller
    {
        private readonly IResturantData _resturantData;

        public HomeController(IResturantData resturantData)
        {
            _resturantData = resturantData;
        }

        public ViewResult Index()
        {
           return View(_resturantData.GetAll());
        }
    }
}
