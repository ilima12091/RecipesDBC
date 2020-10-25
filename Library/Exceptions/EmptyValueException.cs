using System;

namespace Full_GRASP_And_SOLID
{
    public class EmptyValueException: Exception
    {
        public EmptyValueException(string message) : base(message)
        {

        }
    }
}