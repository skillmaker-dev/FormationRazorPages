using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shared.Abstracts;
using Shared.Models;

namespace Formation.Pages
{
    public class ListModel : PageModel
    {
        private readonly IRestaurantsService _service;

        
        public List<Restaurant> Restaurants { get; set; }
        public ListModel(IRestaurantsService service)
        {
            _service = service;
        }
        public void OnGet()
        {
            Restaurants =  _service.GetAllRestaurants();

        }
    }
}
