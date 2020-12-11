using System;
using System.Collections.Generic;
using Contracts;
using Interfaces;


namespace Contracts.OrderManagement
{
    public class Order : IOrder
    {
        public int OrderNumber { get; set; }
        public string UserName { get; set; }
        public double TotalCost { get; set; }
        public DateTime DateOrdered { get; set; }
        public string FinalOrder { get; set; }

        public Dictionary<IOrderItem, int> OrderList;

        public Order(int orderNumber, string userName)
        {
            OrderNumber = orderNumber;
            UserName = userName;
            TotalCost = 0.00;
            DateOrdered = DateTime.Now;
            OrderList = new Dictionary<IOrderItem, int>();

            //Here we make sure the username isn't Null
            if (UserName == null)
            {
                throw new ArgumentNullException("Username cannot be null, no order created");
            }

            if (OrderNumber <= 0)
            {
                throw new System.ArgumentException("Order Number must be greater than 0, no order created");
            }

        }

        public void AddItem(IOrderItem item, int Quantity)
        {
            var toAdd = item;
            bool found = false;
            int newQuantity = 0;
            int index = 0;
            foreach (KeyValuePair<IOrderItem, int> KVP in OrderList)
            {
                if (KVP.Key.ItemID == toAdd.ItemID)
                {
                    found = true;
                    Console.WriteLine("checking");
                    newQuantity = KVP.Value;
                    newQuantity += Quantity;
                    break;
                }
                index++;
            }
            if (found == false)
            {
                OrderList.Add(item, Quantity);
                Console.WriteLine("not found");
            }
            else
            {
                OrderList.Remove(item);
                OrderList.Add(item, newQuantity);
            }
        }

        //This handles removing an item
        public void RemoveItem(int ItemID)
        {
            //We search the order dictionary for a matching item ID to the one we received.
            foreach (KeyValuePair<IOrderItem, int> KVP in OrderList)
            {
                try
                {
                    //When we find the matching ID, we remove it, and break out of the loop
                    if (KVP.Key.ItemID == ItemID)
                    {
                        OrderList.Remove(KVP.Key);
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Item not removed");
                }

            }
        }

        //This handles outputting our order to a JSON object
        public void SubmitOrder()
        {
            //We start building our JSON object with the username, ordernumber, and date, and set up a placeholder for items
            string orderString = $"{{\"userName\":\"{UserName}\",\"orderNumber\":{OrderNumber},\"dateOrdered\":{DateOrdered},\"items\":{{";

            //Now we iterate through our list, adding items as we go
            int i = 0;
            foreach (KeyValuePair<IOrderItem, int> KVP in OrderList)
            {
                //We catch the first item, because it doesn't open with a comma
                if (i == 0)
                {
                    //The first item has no leading comma
                    orderString += $"\"itemID:{KVP.Key.ItemID}\":{KVP.Value}";
                    i++;
                }
                else
                {
                    //For the second and subsequent items, we add a comma to start
                    orderString += $",\"itemID:{KVP.Key.ItemID}\":{KVP.Value}";
                }
            }

            //This closes off the JSON object
            orderString += $"}}}}";

            //And we save our JSON string in an accessible format
            FinalOrder = orderString;
        }

        void IOrder.Order(int orderNumber, string userName)
        {
            throw new NotImplementedException();
        }
    }
}
