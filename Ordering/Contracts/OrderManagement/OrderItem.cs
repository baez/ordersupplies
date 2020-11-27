using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class OrderItem : IOrderItem
    {
        public static int CurrentItemID = 0;

        public int ItemID { get; }
        public string Name { get; set; }
        public string ItemDescription { get; set; }
        public double Price { get; set; }
        public OrderItemCategory Category { get; set; }

        public OrderItem(string name, string itemDescription, double price, OrderItemCategory cateogry)
        {
            ItemID = CurrentItemID;
            Name = name;
            ItemDescription = itemDescription;
            Price = price;
            Category = cateogry;
            CurrentItemID++;

        }
        public override string ToString()
        {
            return $"Item ID: {this.ItemID}, Item: {this.Name}, Price: {this.Price}, Category: {this.Category}, \nDescription: {this.ItemDescription}";
        }
    }
}
