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
        //remove all not implemented exceptions
        //replace list into an array of enum
        public OrderSteps[] Steps {get;}
        public IOrderStep<T> CurrentStep { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public OrderProcessStatus Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // add date the incident is created
        public DateTime IncidentDate { get; set; }
        // add incident number 
        public int IncidentNumber { get; set; }


        //constructor
        //set values in the class, required values
        public OrderProcess(int incidentNumber)
        {
            //add 
            //make it into an array
            Steps = new OrderSteps[4]()
                {
                    
                }
        }


        public void MoveToNextStep()
        {
            //find a current step inside the order steps array
            //set current step next item on the array

            
        }
    }
}
