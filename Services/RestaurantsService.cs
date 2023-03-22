using Shared.Abstracts;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RestaurantsService : IRestaurantsService
    {
        private readonly IRestaurantsRepository _repository;

        public RestaurantsService(IRestaurantsRepository repository)
        {
            _repository = repository;
        }
        public void AddRestaurant(Restaurant restaurant)
        {
            _repository.Restaurants.Add(restaurant);
        }

        public void DeleteRestaurant(int id)
        {
            var restaurantToRemove = GetRestaurant(id);
            if(restaurantToRemove is not null)
            {
                _repository.Restaurants.Remove(restaurantToRemove);
            }
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _repository.Restaurants.ToList();
        }

        public Restaurant? GetRestaurant(int id)
        {
            return _repository.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public void UpdateRestaurant(Restaurant newRestaurant, int id)
        {
            var restaurantToUpdate = GetRestaurant(id);

            if(restaurantToUpdate is not null)
            {
                restaurantToUpdate.Name = newRestaurant.Name;
                restaurantToUpdate.Description = newRestaurant.Description;
            }
        }
    }
}
