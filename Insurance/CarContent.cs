using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    public class Car
    {
        public string BrandOfCar { get; set; }
        public string ModelOfCar { get; set; }
        public short YearOfCar { get; set; }
        public string TypeOfCar { get; set; }
        public string ColorOfCar { get; set; }
        public short NumberOfWheels { get; set; }
        public bool BeenInAccident { get; set; }
        public int NumberOfOwners { get; set; }

        public Car(string brand, string model, short year, string type, string color, short wheelNumber, bool accident, int owners)
        {
            BrandOfCar = brand;
            ModelOfCar = model;
            YearOfCar = year;
            TypeOfCar = type;
            ColorOfCar = color;
            NumberOfWheels = wheelNumber;
            BeenInAccident = accident;
            NumberOfOwners = owners;
        }

        public Car()
        {

        }

        public override string ToString()
        {
            return $"{YearOfCar} {BrandOfCar} {ModelOfCar}, in {ColorOfCar}. {NumberOfWheels} wheels, with {NumberOfOwners} owners.";
        }
    }
}
