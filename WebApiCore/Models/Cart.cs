using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public double cartCost { get; set; }

        public void get_cart_sum(List<Item> allItems) 
        {
            List<Item> items = allItems;
            double suma = 0;

            if (items == null)
            {
                cartCost = suma;
            }
            else
            {
                foreach (Item item in items)
                {
                    suma += item.Cost;
                }
                cartCost = suma;
            }
        }
    }
}
