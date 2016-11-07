using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackProject;

namespace UnitTestStack
{
    [TestClass]
    public class UnitTestStack
    {
        private Stack<string> stack = null;

        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack<string>();
        }


        [TestMethod]
        public void TestEmptyStack()
        {
            Assert.IsTrue(stack.IsEmpty, "The stack isn't empty.");
        }

        [TestMethod]
        public void TestPushOneElement()
        {
            stack.Push("First element");

            Assert.AreEqual<string>("First element", stack.Top);
        }

        [TestMethod]
        public void TestPushSizeOneElement()
        {
            stack.Push("First element");

            Assert.AreEqual<int>(1, stack.Size);
        }
    }
}
