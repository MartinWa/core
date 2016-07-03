using System.Collections.Generic;
using System.Linq;
using core.Entities;

namespace core.Services
{
    public class SqlResturantData : IResturantData
    {
        private readonly CoreDbContext _context;

        public SqlResturantData(CoreDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Resturant> GetAll()
        {
            return _context.Resturants;
        }

        public Resturant Get(int id)
        {
            return _context.Resturants.FirstOrDefault(r => r.Id == id);
        }

        public void Add(Resturant resturant)
        {
            _context.Add(resturant);
            _context.SaveChanges();
        }
    }
}