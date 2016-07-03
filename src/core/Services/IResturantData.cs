using System.Collections.Generic;
using core.Entities;

namespace core.Services
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();
    }
}