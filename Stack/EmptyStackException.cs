﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    public class EmptyStackException : Exception
    {
        public EmptyStackException(string message)
            :base(message)
        {

        }
    }
}
