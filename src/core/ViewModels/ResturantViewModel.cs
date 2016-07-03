using System.ComponentModel.DataAnnotations;
using core.Entities;

namespace core.ViewModels
{
    public class ResturantViewModel
    {
        [Display(Name="Resturant Name")]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}