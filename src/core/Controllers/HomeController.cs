using core.Entities;
using core.Services;
using core.ViewModels;
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

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Resturants = _resturantData.GetAll()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
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
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, ResturantEditViewModel editmodel)
        {
            var resturant = _resturantData.Get(id);
            if (!ModelState.IsValid || resturant == null)
            {
                return View(editmodel);
            }
            resturant.Name = editmodel.Name;
            resturant.Cuisine = editmodel.Cuisine;
            _resturantData.Commit();
            return RedirectToAction("Details", new { id = resturant.Id });
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
            _resturantData.Commit();
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
                Id = resturant.Id,
                Name = resturant.Name,
                Cuisine = resturant.Cuisine
            };
            return View(model);
        }
    }
}
