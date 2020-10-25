using System;

namespace Full_GRASP_And_SOLID
{
    public class UnknownStepException: Exception
    {
        public UnknownStepException(string message, Step step) : base(message)
        {

        }
    }
}