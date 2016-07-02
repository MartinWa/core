using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace core.Controller
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
