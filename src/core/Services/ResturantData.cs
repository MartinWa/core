using System.Collections.Generic;
using core.Entities;

namespace core.Services
{
    public class InMemoryResturantData : IResturantData
    {
        private readonly IEnumerable<Resturant> _resturants;

        public InMemoryResturantData()
        {
            _resturants = new List<Resturant>
            {
                new Resturant{Id = 1,Name = "Tersiguel's"},
                new Resturant {Id = 2, Name = "LJ's and the Kat"},
                new Resturant {Id = 3, Name = "King's Contrivance"}
            };
        }

        public IEnumerable<Resturant> GetAll()
        {
            return _resturants;
        }
    }
}
