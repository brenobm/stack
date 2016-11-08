using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    public class MaxSizeStackException : Exception
    {
        public MaxSizeStackException(string message):
            base(message)
        {

        }
    }
}
