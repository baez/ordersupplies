using Ordering.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ordering.BusinessLogic.OrderManagement
{
    class OrderFramework:IOrderManager
    {
        public SortedList<Object, int> newOrder = new SortedList<object, int>();


        public void AddItem(Object Item, int Quantity)
        {
            object toAdd = Item;
            bool found = false;
            int newQuantity = 0;
            int index = 0;
            foreach (KeyValuePair<object, int> KVP in newOrder)
            {
                if (KVP.Key == toAdd)
                {
                    found = true;
                    newQuantity = KVP.Value;
                    newQuantity += Quantity;
                    break;
                }
                index++;
            }
            if (found == false)
            {
                newOrder.Add(Item, Quantity);
            }
            else
            {
                newOrder.RemoveAt(index);
                newOrder.Add(Item, newQuantity);
            }
        }

        public void RemoveItem(object Item)
        {
            newOrder.Remove(Item);
        }

        public void ViewOrder()
        {
            Console.WriteLine("Here is your current order:");

            foreach (KeyValuePair<object, int> KVP in newOrder)
            {
                Console.WriteLine($"The order currently has {KVP.Value} units of {KVP.Key}");
            }
            if (newOrder.Count < 1)
            {
                Console.WriteLine("There are no items in the order!");
            }
        }

    }
}
