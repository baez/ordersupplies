using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagement
{
    public interface IOrderProcessManager
    {
        void MoveToNextStep(IOrderProcess orderProcess);
    }
}
