using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery
{
    public class ProgramUI
    {
        ProductRepository _productRepo = new ProductRepository();
        Product _product = new Product();


        public void Run()
        {

            bool endProgram = false;

            while (!endProgram)
            {
                Console.WriteLine("Welcome to Baker Street Bakery!\n");
                Console.WriteLine("New Order\n...\n...");
                Console.WriteLine("Customer's first and last name?");
                string customerName = Console.ReadLine();


                Console.WriteLine("Customer's order:");
                Console.WriteLine("1: Bread\n" +
                    "2: Cake\n" +
                    "3: Pastry\n" +
                    "4: Pies");
                string response = Console.ReadLine();
                int input = int.Parse(response);
                
                BakeType type;

                switch (input)
                {
                    case 1:
                        type = BakeType.Bread;
                        break;
                    case 2:
                        type = BakeType.Cake;
                        break;
                    case 3:
                        type = BakeType.Pastry;
                        break;
                    case 4:
                    default:
                        type = BakeType.Pies;
                        break;
                }


                Console.WriteLine("Give this particular item a name:");
                string productName = Console.ReadLine();
                decimal orderCost = _productRepo.Costs(type);


                Console.WriteLine("Order quantity?");
                int orderBatchSize = Convert.ToInt32(Console.ReadLine());

                Product _product = new Product(type, productName, customerName, orderBatchSize, orderCost);

                _productRepo.AddProductToList(_product);


                Console.WriteLine("Do you want to see the list of orders?");
                Console.WriteLine(
                    "1: Yes \n" +
                    "2: No");
                int viewOrders = Convert.ToInt32(Console.ReadLine());
                List<Product> _products = _productRepo.GetProductFromList();
                if (viewOrders == 1)
                {
                    foreach (Product product in _products)
                    {
                        Console.WriteLine(product);
                    }
                }


                Console.WriteLine("Would you like to place another order?");
                Console.WriteLine(
                    "1: Yes \n" +
                    "2: No");
                int startAnOrder = Convert.ToInt32(Console.ReadLine());
                switch (startAnOrder)
                {
                    case 1:
                        endProgram = false;
                        break;
                    case 2:
                        endProgram = true;
                        break;
                }
            }

            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }

    }
}