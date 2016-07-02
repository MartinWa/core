using Microsoft.AspNetCore.Mvc;

namespace core.Controllers
{
    [Route("info/about/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "phonenr";
        }

        public string Country()
        {
            return "SW";
        }
    }
}
