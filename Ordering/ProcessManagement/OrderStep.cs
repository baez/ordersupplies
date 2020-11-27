using Interfaces.ProcessManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagement
{
    public class OrderStep<T> : IOrderStep<T>
    {
        // add step activation datetime

        public Interfaces.IOrderQueue<T> OrderQueue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
