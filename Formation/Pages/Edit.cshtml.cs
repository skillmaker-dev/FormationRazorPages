using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shared.Abstracts;
using Shared.Models;

namespace Formation.Pages
{
    public class EditModel : PageModel
    {
        private readonly IRestaurantsService _service;

        public EditModel(IRestaurantsService service)
        {
            _service = service;
        }
        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public IActionResult OnGet(int id)
        {
            var restaurant = _service.GetRestaurant(id);
            if(restaurant is not null) 
            {
                Restaurant = restaurant;
            }
            else
            {
                return RedirectToPage("Index");
            }

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            _service.UpdateRestaurant(Restaurant, id);

            return RedirectToPage("List");
        }
    }
}
