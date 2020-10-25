using System;

namespace Full_GRASP_And_SOLID
{
    public class EmptyStepsListException: Exception
    {
        public EmptyStepsListException(string message) : base(message)
        {

        }
    }
}