using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shared.Abstracts;
using Shared.Models;

namespace Formation.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IRestaurantsService _service;

        public CreateModel(IRestaurantsService service)
        {
            _service = service;
        }
        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Restaurant.Id = _service.GetAllRestaurants().Max(x => x.Id) + 1;
            _service.AddRestaurant(Restaurant);

            return RedirectToPage("List");
        }
    }
}
