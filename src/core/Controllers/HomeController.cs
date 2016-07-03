using core.Entities;
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

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Resturants = _resturantData.GetAll(),
                CurrentGreeting = _greeter.GetGreeting()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ResturantEditViewModel editmodel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var resturant = new Resturant
            {
                Name = editmodel.Name,
                Cuisine = editmodel.Cuisine
            };
            _resturantData.Add(resturant);
            return RedirectToAction("Details", new { id = resturant.Id });
        }

        public IActionResult Details(int id)
        {
            var resturant = _resturantData.Get(id);
            if (resturant == null)
            {
                return RedirectToAction("Index");
            }
            var model = new ResturantViewModel
            {
                Name = resturant.Name,
                Cuisine = resturant.Cuisine
            };
            return View(resturant);
        }
    }
}
