using System;

namespace Full_GRASP_And_SOLID
{
    public class RemoveStepException: Exception
    {
        public RemoveStepException(string message, Step step) : base(message)
        {

        }
    }
}