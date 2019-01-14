using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            Car pinto = new Car("Ford", "Pinto", 1986, "car", "rust", 3, true, 1);
            Car explorer = new Car("Ford", "Explorer", 1996, "SUV", "black", 4, false, 2);
            CarContentRepository repo = new CarContentRepository();

            repo.AddContentToList(pinto);
            repo.AddContentToList(explorer);

            cars = repo.GetContentFromList();
            // ^ Need this line to establish the variable "cars" in 
            // this program (pulling from the repository)

            foreach (Car model in cars)
            {
                Console.WriteLine(model);
            }

            Console.ReadLine();


            ////Code from David:

            //int modelYearInput;
            //bool whatever = false;
            //while (!whatever)
            //{
            //    string input = Console.ReadLine();
            //    whatever = int.TryParse(input, out modelYearInput);
            //}

        }   
    }
}
