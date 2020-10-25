using System;

namespace Full_GRASP_And_SOLID
{
    public class LessThanZeroException: Exception
    {
        public LessThanZeroException(string message) : base(message)
        {

        }
    }
}