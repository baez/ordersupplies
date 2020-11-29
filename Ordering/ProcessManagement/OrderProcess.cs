using Interfaces;
using Interfaces.ProcessManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagement
{
    public class OrderProcess<T> : IOrderProcess<T>
    {
        public List<IOrderStep<T>> Steps { get; set; }
        public IOrderStep<T> CurrentStep { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public OrderProcessStatus Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // add date the incident is created
        // add incident number 
        // 
        public OrderProcess()
        {
            Steps = new List<IOrderStep<T>>()
            {
                new CreateOrderStep<T>()
            };
        }
    }
}
