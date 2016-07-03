using core.services;
using core.Services;
using core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace core.Controllers
{
    public class HomeController : Controller
    {
        private readonly IResturantData _resturantData;
        private readonly IGreeter _greeter;

        public HomeController(IResturantData resturantData, IGreeter greeter)
        {
            _resturantData = resturantData;
            _greeter = greeter;
        }

        public ViewResult Index()
        {
            var model = new HomeViewModel
            {
                Resturants = _resturantData.GetAll(),
                CurrentGreeting = _greeter.GetGreeting()
            };
           return View(model);
        }
    }
}
