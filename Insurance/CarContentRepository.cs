using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    public class CarContentRepository
    {
        public decimal InsuranceCost(int year)
        {
            decimal insurance;

            if (year >= 1960 && year < 1971)
            {
                insurance = 50m;
            }
            else if (year >= 1971 && year < 1981)
            {
                insurance = 75m;
            }
            else if (year >=1981 && year < 1991)
            {
                insurance = 150m;
            }
            else
            {
                insurance = 2000m;
            }
            return insurance;
        }


        // the next code creates a new list (with class "Car").  
        // The list is assigned a variable name (cars).
        List<Car> cars = new List<Car>();


        // the next code creates methods to add cars to the list Car
        // and also a way to return the finished list "cars" back to the rest of the program
        public void AddContentToList(Car car)
        {
            cars.Add(car);
        }

        public List<Car> GetContentFromList()
        {
            return cars;
        }


    }

}
