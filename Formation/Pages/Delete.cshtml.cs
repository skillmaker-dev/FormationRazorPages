using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shared.Abstracts;
using Shared.Models;
using System.ComponentModel.Design;

namespace Formation.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly IRestaurantsService _service;

        public DeleteModel(IRestaurantsService service)
        {
            _service = service;
        }

        [BindProperty]
        public int Id { get; set; }

        public Restaurant Restaurant { get; set; }

        public IActionResult OnGet(int id)
        {
            var restaurant = _service.GetRestaurant(id);
            if (restaurant is null)
                return RedirectToPage("details", new {id});

            Restaurant = restaurant;

            return Page();
        }

        public IActionResult OnPost()
        {
            _service.DeleteRestaurant(Id);
            return RedirectToPage("List");
        }
    }
}
