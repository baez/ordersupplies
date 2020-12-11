using Contracts.OrderManagement;
using Interfaces;
using Interfaces.QueueManagement;
using ProcessManagement;
using QueueManagement;
using System.Collections.Generic;

namespace WpfApp
{
    public class QueueManager
    {
        private static Dictionary<ProcessStep, IOrderQueue<Order>> Queues;

        public QueueManager()
        {
            InitializeQueues();            
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

        private void InitializeQueues()
        {
            Queues = new Dictionary<ProcessStep, IOrderQueue<Order>>(ProcessHelper.GetProcessStepsCount());

            ProcessStep[] steps = ProcessHelper.GetProcessSteps();
            for (int i = 0; i < steps.Length; i++)
            {
                Queues[steps[i]] = new OrderQueue<Order>();
            }
        }
    }
}
