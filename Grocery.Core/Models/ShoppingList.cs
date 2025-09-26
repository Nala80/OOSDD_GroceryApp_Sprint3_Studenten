using Grocery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Models
{
    public class ShoppingList
    {
        public List<ShoppingListItem> Items { get; } = new List<ShoppingListItem>();

        public void AddProduct(Product product, int quantity)
        {
            var existing = Items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                Items.Add(new ShoppingListItem(product, quantity));
            }
        }
    }
}
