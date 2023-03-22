using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Abstracts
{
    public interface IRestaurantsService
    {
        void AddRestaurant(Restaurant restaurant);
        List<Restaurant> GetAllRestaurants();
        Restaurant? GetRestaurant(int id);
        void DeleteRestaurant(int id);
        void UpdateRestaurant(Restaurant restaurant, int id);
    }
}
