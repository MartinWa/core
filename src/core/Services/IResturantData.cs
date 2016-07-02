using System.Collections.Generic;
using core.Models;

namespace core.Services
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();
    }
}