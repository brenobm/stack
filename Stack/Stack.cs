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
                return this.size == 0;
            }
        }

        public T Top
        {
            get
            {
                return this.element;
            }
        }

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public Stack<T> Push(T element)
        {
            this.element = element;
            this.size++;
            return this;
        }

        public T Pop()
        {
            this.size--;
            return this.element;
        }

        private int size;
        private T element;              
    }
}
