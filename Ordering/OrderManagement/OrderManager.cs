using Ordering.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.OrderManagement;



namespace Ordering.BusinessLogic.OrderManagement
{
    public class OrderManager:IOrderManager
    {
        public int OrderNumber { get; set; }
        public string UserName { get; set; }
        public Order NewOrder { get; set; }

        public OrderManager(int orderNumber, string userName)
        {
            OrderNumber = orderNumber;
            UserName = userName;
            NewOrder = new Order(orderNumber, userName);
    }

        //public SortedList<Object, int> newOrder = new SortedList<Object, int>();
        

        public void AddItem(OrderItem Item, int Quantity)
        {
            OrderItem toAdd = Item;
            bool found = false;
            int newQuantity = 0;
            int index = 0;
            foreach (KeyValuePair<OrderItem, int> KVP in NewOrder.OrderList)
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
                NewOrder.OrderList.Add(Item, Quantity);
            }
            else
            {
                NewOrder.OrderList.RemoveAt(index);
                NewOrder.OrderList.Add(Item, newQuantity);
            }
        }

        public void RemoveItem(OrderItem Item)
        {
            NewOrder.OrderList.Remove(Item);
        }

        public void ViewOrder()
        {
            Console.WriteLine("Here is your current order:");

            foreach (KeyValuePair<OrderItem, int> KVP in NewOrder.OrderList)
            {
                Console.WriteLine($"The order currently has {KVP.Value} units of {KVP.Key}");
            }
            if (NewOrder.OrderList.Count < 1)
            {
                Console.WriteLine("There are no items in the order!");
            }
        }

    }
}
