using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    public class Stack<T>
    {
        public bool IsEmpty
        {
            get
            {
                return size == 0;
            }
        }

        private int size;
    }
}
