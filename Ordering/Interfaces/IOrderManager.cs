using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Common.Interfaces
{
    public interface IOrderManager
    {
        //This is used to add an item to an order
        void AddItem(IOrderItem Item, int Quantity);

        //This is used to Remove an item from an order
        void RemoveItem(IOrderItem Item);

        //This allows us to print the contents of an order to console
        void ViewOrder();
    }
}
