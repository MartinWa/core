using System.Collections.Generic;
using core.Entities;

namespace core.Services
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();
        Resturant Get(int id);
        void Add(Resturant resturant);
        void Commit();
    }
}