using System.Collections.Generic;
using core.Entities;

namespace core.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Resturant> Resturants { get; set; }
        public string CurrentGreeting { get; set; }
    }
}
