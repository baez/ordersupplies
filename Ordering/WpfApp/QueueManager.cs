using Contracts.OrderManagement;
using Interfaces;
using Interfaces.QueueManagement;
using ProcessManagement;
using System.Collections.Generic;

namespace WpfApp
{
    public class QueueManager
    {
        private static Dictionary<ProcessStep, IOrderQueue<Order>> Queues;

        public QueueManager()
        {
            Queues = new Dictionary<ProcessStep, IOrderQueue<Order>>(ProcessHelper.GetProcessStepCount());
        }

        public void InitiateOrder(Order order)
        {
            AddToQueue(ProcessStep.CreateOrderStep, order);
        }

        private void AddToQueue(ProcessStep processStep, Order order)
        {
            if (Queues.ContainsKey(processStep))
            {
                Queues[processStep].Enqueue(order);
            }
        }
    }
}
