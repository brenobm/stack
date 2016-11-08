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
                return this.top.Element;
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
            StackItem<T> stackItem = new StackItem<T>(element, this.top);
            this.top = stackItem;
            this.size++;

            return this;
        }

        public T Pop()
        {
            if (this.size == 0)
            {
                throw new EmptyStackException("Stack empty.");
            }

            T item = this.top.Element;
            this.top = this.top.NextElement;
            this.size--;

            return item;
        }

        private int size;
        private int maxSize;
        private StackItem<T> top;

        private class StackItem<T>
        {
            public StackItem(T element, StackItem<T> nextElement)
            {
                this.Element = element;
                this.NextElement = nextElement;
            }

            public T Element { get; set; }

            public StackItem<T> NextElement { get; set; }
        }
    }
}
