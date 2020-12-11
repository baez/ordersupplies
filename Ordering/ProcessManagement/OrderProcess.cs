using Interfaces;
using Interfaces.ProcessManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagement
{
    public class OrderProcess : IOrderProcess
    {
        public ProcessStep CurrentStep { get; private set; }

        public OrderProcessStatus Status { get; private set;  }

        public DateTime IncidentActivationTime { get; }
        
        public int IncidentNumber { get; }
        
        public OrderProcess(int incidentNumber)
        {
            IncidentNumber = incidentNumber;
            IncidentActivationTime = DateTime.UtcNow;
        }

        public void MoveToNextStep()
        {
            if (Status == OrderProcessStatus.Completed || 
                Status == OrderProcessStatus.Cancelled ||
                CurrentStep == ProcessStep.OrderCompletedStep)
            {
                return;
            }

            var steps = (ProcessStep[])Enum.GetValues(typeof(ProcessStep));
            for(int i = 0; i < steps.Length; i++)
            {
                if (steps[i] == CurrentStep)
                {
                    CurrentStep = steps[i + 1];
                    break;
                }
            }

            if (CurrentStep == ProcessStep.OrderCompletedStep)
            {
                Status = OrderProcessStatus.Completed;
            }
        }

        public void Cancel()
        {
            Status = OrderProcessStatus.Cancelled;
        }
    }
}
