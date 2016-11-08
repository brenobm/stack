using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    public class Stack<T>
    {
        public Stack(int maxSize)
        {
            this.elements = new T[maxSize];
            this.maxSize = maxSize;
        }

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
                return this.elements[this.size - 1];
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
            if (this.size == this.maxSize)
            {
                //throw new MaxSizeStackException("Stack full.");
            }
            else
            {
                this.elements[this.size++] = element;
            }

            return this;
        }

        public T Pop()
        {
            if (this.size == 0)
            {
                throw new EmptyStackException("Stack empty.");
            }

            return this.elements[--this.size];
        }

        private int size;
        private int maxSize;
        private T[] elements;              
    }
}
