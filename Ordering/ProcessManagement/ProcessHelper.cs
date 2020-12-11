using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagement
{
    public static class ProcessHelper
    {
        public static ProcessStep[] GetProcessStep()
        {
            return (ProcessStep[])Enum.GetValues(typeof(ProcessStep));
        }

        public static int GetProcessStepCount()
        {
            return ((ProcessStep[])Enum.GetValues(typeof(ProcessStep))).Length;
        }

    }
}
