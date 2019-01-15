using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery
{
    public enum BakeType { Bread, Cake, Pastry, Pies}

    public class Product
    {
        public BakeType Type { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public int OrderBatchSize { get; set; }
        public decimal OrderCost { get; set; }

        public Product (BakeType type, string productName, string customerName, int orderBatchSize, decimal orderCost)
        {
            Type = type;
            ProductName = productName;
            CustomerName = customerName;
            OrderBatchSize = orderBatchSize;
            OrderCost = orderCost;
        }

        public Product()
        {

        }

        public override string ToString()
        {
            return $"{CustomerName} ordered {OrderBatchSize} {ProductName}. Total cost: {OrderCost}";
        }
    }
}
