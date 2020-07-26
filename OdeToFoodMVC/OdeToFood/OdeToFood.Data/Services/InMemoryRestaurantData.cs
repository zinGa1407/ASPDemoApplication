﻿using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Alex's Pizza", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Ind Curry", Cuisine = CuisineType.Indian },
                new Restaurant { Id = 3, Name = "Baguette", Cuisine = CuisineType.French }

            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
