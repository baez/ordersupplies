using Interfaces;
using Interfaces.ProcessManagement;
using System;

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
            //add 
            //make it into an array
            Steps = new ProcessStep[4]()
                {
                    
                }

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
            ProcessStep[] steps = ProcessHelper.GetProcessSteps();
            for (int i = 0; i < steps.Length; i++)
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
