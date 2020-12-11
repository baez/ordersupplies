using Contracts.OrderManagement;
using Interfaces.QueueManagement;
using QueueManagement;

namespace WpfApp
{
    public class QueueManager
    {
        private IOrderQueue<Order> InitiateOrderQueue;

        public QueueManager()
        {
            InitiateOrderQueue = new OrderQueue<Order>();
        }

        public void AddOrder(Order order)
        {
            InitiateOrderQueue.Enqueue(order);
        }
    }
}
