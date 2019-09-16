using OdeToFood.Core;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant Update(Restaurant updatedRestaurant);
        int Commit();
        Restaurant GetById(int id);
        Restaurant Add(Restaurant newRestaurant);
    }
}
