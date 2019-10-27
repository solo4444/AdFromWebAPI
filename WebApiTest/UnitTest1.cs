using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WebApiCore.Models;

namespace WebApiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sum_calculation()
        {
            double itemCost = 20.20;
            string itemName = "elektriukas";
            double expected = 20.20;
            
            Cart cart = new Cart();
            Item item = new Item();

            item.Cost = itemCost;
            item.Name = itemName;

            List<Item> items = new List<Item>();
            items.Add(item);

            cart.get_cart_sum(items);

            double actual = cart.cartCost;

            Assert.AreEqual(expected, actual, 0.001, "Cart cost is not summed correctly");
        }
    }
}
