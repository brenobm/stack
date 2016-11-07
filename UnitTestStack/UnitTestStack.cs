﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackProject;

namespace UnitTestStack
{
    [TestClass]
    public class UnitTestStack
    {
        [TestMethod]
        public void TestEmptyStack()
        {
            Stack stack = new Stack();

            Assert.IsTrue(stack.IsEmpty, "The stack isn't empty.");
        }
    }
}