using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        public Restaurant GetById(int id);
        Restaurant Update(Restaurant updatedRestaurant);
        int Commit();
    }
}
