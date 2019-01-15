using System;
using System.Collections.Generic;
using BakerStreetBakery;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BakeryChallenge_Tests
    {
        [TestMethod]
        public void BakeryTests_AddingContent_ShouldBeCorrect()
        {
            Product productOne = new Product(BakeType.Bread, "Amish Bread", "Angela Whatever", 5, 245.3m);
            ProductRepository repo = new ProductRepository();

            repo.AddProductToList(productOne);

            Assert.AreEqual("Amish Bread", productOne.ProductName);
        }

        [TestMethod]
        public void BakeryTests_GetFromList_ShouldBeCorrect()
        {
            List<Product> products = new List<Product>();

            Product productOne = new Product(BakeType.Bread, "Amish Bread", "Angela Whatever", 5, 245.3m);
            Product productTwo = new Product(BakeType.Cake, "birthday cake", "Bogamila Schrute", 1, 25.75m);
            ProductRepository repo = new ProductRepository();

            repo.AddProductToList(productOne);
            repo.AddProductToList(productTwo);

            int actual = productTwo.OrderBatchSize;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BakeryTests_RemoveFromList_ShouldBeCorrect()
        {
            //List<Product> products = new List<Product>();

            Product productOne = new Product(BakeType.Bread, "Amish Bread", "Angela Whatever", 5, 245.3m);
            Product productTwo = new Product(BakeType.Cake, "birthday cake", "Bogamila Schrute", 1, 25.75m);
            ProductRepository repo = new ProductRepository();

            repo.AddProductToList(productOne);
            repo.AddProductToList(productTwo);

            repo.RemoveProductFromList(productOne);

            int actual = repo.GetProductFromList().Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);

            //foreach(Product product in products)
            //{
            //    if(product.CustomerName == "Angela Whatever")
            //    {
            //        products.Remove(product);
            //    }

            //}
        }
    }
}
