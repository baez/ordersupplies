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

        public SortedList<OrderItem, int> OrderList;

        public Order(int orderNumber, string userName)
        {
            OrderNumber = orderNumber;
            UserName = userName;
            TotalCost = 0.00;
            DateOrdered = DateTime.Now;
            OrderList = new SortedList<OrderItem, int>();

            //Here we make sure the username isn't Null
            if (UserName == null)
            {
                throw new System.ArgumentException("Username cannot be null, no order created");
            }

            if (OrderNumber <= 0)
            {
                throw new System.ArgumentException("Order Number must be greater than 0, no order created");
            }

        }

    }
}
