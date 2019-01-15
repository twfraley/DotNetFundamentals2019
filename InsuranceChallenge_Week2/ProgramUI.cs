using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery
{
    public enum YesNo { Yes, No }

    public class ProgramUI
    {
            ProductRepository _productRepo = new ProductRepository();
        public void Run()
        {

            bool endProgram = false;

            Console.WriteLine("Welcome to Baker Street Bakery!");
            Console.WriteLine("Would you like to place an order?");
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


            Console.WriteLine("New Order\n\n");
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
                    type = BakeType.Pies;
                    break;
            }

            decimal totalCost = _productRepo.Costs(type);

            Console.WriteLine("Order quantity?");

            int orderBatchSize = Convert.ToInt32(Console.ReadLine());

            Product product = new Product(type, productName, customerName, orderBatchSize, orderCost);


        }
    }
}
