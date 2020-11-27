using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.ProcessManagement
{
    public interface IOrderProcessManager<T>
    {
        void MoveToNextStep(IOrderProcess<T> orderProcess);
    }
}
