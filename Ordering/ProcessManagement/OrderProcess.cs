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
        private const int NumberOfSteps = 4;
        //remove all not implemented exceptions
        //replace list into an array of enum
        public ProcessStep CurrentStep { get; private set; }

        public OrderProcessStatus Status { get; }

        // add date the incident is created
        public DateTime IncidentActivationTime { get; }
        // add incident number 
        
        public int IncidentNumber { get; }
        
        //constructor
        //set values in the class, required values
        public OrderProcess(int incidentNumber)
        {
            //add 
            //make it into an array
            IncidentNumber = incidentNumber;
            IncidentActivationTime = DateTime.UtcNow;
        }


        public void MoveToNextStep()
        {
            if (CurrentStep == ProcessStep.OrderCompletedStep)
            {
                return;
            }

            //find a current step inside the order steps array
            //set current step next item on the array
            var steps = (ProcessStep[])Enum.GetValues(typeof(ProcessStep));
            for(int i = 0; i < steps.Length; i++)
            {
                if (steps[i] == CurrentStep)
                {
                    CurrentStep = steps[i + 1];
                    break;
                }
            }
        }
    }
}
