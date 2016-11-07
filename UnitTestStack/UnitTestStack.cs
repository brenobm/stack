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
            string element = "First element";

            stack.Push(element);

            Assert.AreEqual<string>(element, stack.Top);
        }

        [TestMethod]
        public void TestPushSizeOneElement()
        {
            string element = "First element";

            stack.Push(element);

            Assert.AreEqual<int>(1, stack.Size);
        }

        [TestMethod]
        public void TestPushPopElement()
        {
            string element = "First element";

            stack.Push(element);

            Assert.IsFalse(stack.IsEmpty);
            Assert.AreEqual<string>(element, stack.Pop());
            Assert.IsTrue(stack.IsEmpty);
        }
    }
}
