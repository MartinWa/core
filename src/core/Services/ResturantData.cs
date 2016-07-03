using System.Collections.Generic;
using System.Linq;
using core.Entities;

namespace core.Services
{
    public class InMemoryResturantData : IResturantData
    {
        private static readonly List<Resturant> Resturants;

        static InMemoryResturantData()
        {
            Resturants = new List<Resturant>
            {
                new Resturant{Id = 1,Name = "Tersiguel's"},
                new Resturant {Id = 2, Name = "LJ's and the Kat"},
                new Resturant {Id = 3, Name = "King's Contrivance"}
            };
        }

        public IEnumerable<Resturant> GetAll()
        {
            return Resturants;
        }

        public Resturant Get(int id)
        {
            return Resturants.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Resturant resturant)
        {
            resturant.Id = Resturants.Max(r => r.Id) + 1;
            Resturants.Add(resturant);
        }

        public void Commit()
        {
        }
    }
}
