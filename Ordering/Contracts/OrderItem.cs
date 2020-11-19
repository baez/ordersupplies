using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.OrderManagement;

namespace Contracts
{
    public class OrderItem : IOrderItem
    {
        public string Name { get; set; }
        public string ItemDescription { get; set; }
        public double Price { get; set; }
        public DateTime DateLastOrdered { get; set; }
        public string Category { get; set; }

        public OrderItem(string thisName,string thisItemDescription,double thisPrice,DateTime thisdate,string thisCategory)
        {
            Name = thisName;
            ItemDescription = thisItemDescription;
            Price = thisPrice;
            DateLastOrdered = thisdate;
            Category = thisCategory;

        }
        public override string ToString()
        {
            return $"Item: {this.Name}, Description: {this.ItemDescription}, Price:{this.Price}, Category:{this.Category}, Last Ordered Date: {this.DateLastOrdered} ";
        }
    }
}
