using Interfaces;
using System;

namespace ProcessManagement
{
    public static class ProcessHelper
    {
        public static ProcessStep[] GetProcessSteps()
        {
            return (ProcessStep[])Enum.GetValues(typeof(ProcessStep));
        }

        public static int GetProcessStepsCount()
        {
            return ((ProcessStep[])Enum.GetValues(typeof(ProcessStep))).Length;
        }
    }
}
