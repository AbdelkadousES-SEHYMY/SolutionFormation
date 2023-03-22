using Formation.Models;

namespace Formation.Services
{
    public interface IRestaurantService
    {
        Restaurant GetRestaurant(string id);
        List<Restaurant> getAllRestaurants();
        Restaurant AddRestaurant(Restaurant restaurant);
        Restaurant UpdateRestaurant(Restaurant newRestaurant);
        Restaurant DeleteRestaurant(string id);
    }
}
