using Formation.Models;
using Formation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation.Pages
{
    public class AddRestaurantModel : PageModel
    {
        [BindProperty]
        public Restaurant Restaurant { get; set; }
        private readonly IRestaurantService _restaurantService;
        public List<Restaurant> restaurants;

        public AddRestaurantModel(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            //restaurants = _restaurantService.getAllRestaurants();
            if(ModelState.IsValid)
            {
                _restaurantService.AddRestaurant(Restaurant);
                return RedirectToPage("Index");
            }
            return Page();


        }
    }
}
