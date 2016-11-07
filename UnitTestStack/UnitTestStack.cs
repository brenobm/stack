using System;
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
            Stack<string> stack = new Stack<string>();

            Assert.IsTrue(stack.IsEmpty, "The stack isn't empty.");
        }

        [TestMethod]
        public void TestPushOneElement()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("First element");

            Assert.AreEqual<string>("First element", stack.Top);
        }
    }
}
