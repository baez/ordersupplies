using System;
using Contracts.OrderManagement;
using Interfaces;
using Ordering.BusinessLogic.OrderManagement;
using ProcessManagement;

namespace TestingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //var TestOrder = new OrderManager(123, "Jordan");
            //TestOrder.AddItem("hello", 1);
            //TestOrder.AddItem("hello", 1);
            //TestOrder.AddItem("hi", 3);

            //TestOrder.ViewOrder();
            //Console.WriteLine(TestOrder.NewOrder.UserName);

        }

        public static void TestOrderProcess()
        {
            var orderProcess = new OrderProcess<IOrder>();
        }


    }
}
