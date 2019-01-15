using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery
{
    public class ProductRepository
    {
        List<Product> products = new List<Product>();


        public void AddProductToList(Product product)
        {
            products.Add(product);
        }


        public void RemoveProductFromList(Product product)
        {
            products.Remove(product);
        }


        public List<Product> GetProductFromList()
        {
            return products;
        }



        public decimal Costs(BakeType type)
        {
            decimal bakingCosts = 100m;

            switch (type)
            {
                case BakeType.Bread:
                    bakingCosts += 500.01m;
                    break;
                case BakeType.Cake:
                    bakingCosts += 2000m;
                    break;
                case BakeType.Pastry:
                    bakingCosts += 200.10m;
                    break;
                case BakeType.Pies:
                    bakingCosts += 851.50m;
                    break;
            }
            return bakingCosts;


            //if (type == BakeType.Bread)
            //{
            //    decimal actualBakingCosts = bakingCosts + 500.01m;
            //    return actualBakingCosts;
            //}
            //else if (type == BakeType.Cake)
            //{
            //    decimal actualBakingCosts = bakingCosts + 2000m;
            //    return actualBakingCosts;
            //}
            //else if (type == BakeType.Pastry)
            //{
            //    decimal actualBakingCosts = bakingCosts + 200.10m;
            //    return actualBakingCosts;
            //}
            //else if (type == BakeType.Pies)
            //{
            //    decimal actualBakingCosts = bakingCosts + 851.50m;
            //    return actualBakingCosts;
            //}
            //else
            //{
            //    decimal actualBakingCosts = bakingCosts;
            //    return actualBakingCosts;
            //}
        }
    }
}
