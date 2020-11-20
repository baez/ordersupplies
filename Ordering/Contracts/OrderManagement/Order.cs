using System;
using System.Collections.Generic;
using Contracts;
using Interfaces;


namespace Contracts.OrderManagement
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public string UserName { get; set; }
        public double TotalCost { get; set; }
        public DateTime DateOrdered { get; set; }

        public SortedList<IOrderItem, int> OrderList;

        public Order(int orderNumber, string userName)
        {
            OrderNumber = orderNumber;
            UserName = userName;
            TotalCost = 0.00;
            DateOrdered = DateTime.Now;
            OrderList = new SortedList<IOrderItem, int>();

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

    }
}
