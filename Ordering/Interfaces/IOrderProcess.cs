using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.ProcessManagement
{
    public interface IOrderProcess<T>
    {
        List<IOrderStep<T>> Steps { get; set; }

        IOrderStep<T> CurrentStep { get; set; }

        OrderProcessStatus Status { get; set; }

    }
}
