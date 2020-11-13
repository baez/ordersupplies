using System;
using System.Collections.Generic;


namespace Contracts.OrderManagement
{
    public class Order
    {
        public int OrderNumber;
        public string UserName;
        public double TotalCost;
        public DateTime DateOrdered;
        public SortedList<Object, int> NewOrder;

        public Order(int orderNumber, string userName)
        {
            OrderNumber = orderNumber;
            UserName = userName;
            TotalCost = 0.00;
            DateOrdered = DateTime.Now;
            NewOrder = new SortedList<object, int>();
        }

        //Need to test order, and modify order framework to make sure it integrates

    }
}
