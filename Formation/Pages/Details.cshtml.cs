using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shared.Abstracts;
using Shared.Models;

namespace Formation.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRestaurantsService _service;

        public DetailsModel(IRestaurantsService service)
        {
            _service = service;
        }

        public Restaurant Restaurant { get; set; }
        public IActionResult OnGet(int id)
        {
            var restaurant = _service.GetRestaurant(id);

            if (restaurant is null)
                return RedirectToPage("index");

            Restaurant = restaurant;

            return Page();
        }
    }
}
