using System.ComponentModel.DataAnnotations;
using core.Entities;

namespace core.ViewModels
{
    public class ResturantEditViewModel
    {
        [Display(Name = "Resturant Name")]
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}