using core.services;
using Microsoft.AspNetCore.Mvc;

namespace core.ViewComponent
{
    public class Greeting : Microsoft.AspNetCore.Mvc.ViewComponent
     {
        private readonly IGreeter _greeter;

        public Greeting(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetGreeting();
            return View("Default", model);
        }
     }
}
