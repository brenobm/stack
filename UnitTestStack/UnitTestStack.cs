using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackProject;

namespace UnitTestStack
{
    [TestClass]
    public class UnitTestStack
    {
        private Stack<string> stack = null;
        private int maxSize = 10;

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

        [TestMethod]
        public void TestPushPopTwoElements()
        {
            string element1 = "First element";
            string element2 = "Second element";

            stack.Push(element1);

            Assert.IsFalse(stack.IsEmpty);

            stack.Push(element2);

            Assert.AreEqual<string>(element2, stack.Pop());
            Assert.AreEqual<string>(element1, stack.Pop());

            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void TestPopInEmptyStack()
        {
            stack.Pop();
        }

        [TestMethod]
        public void TestPushPopManyElements()
        {
            Assert.IsTrue(stack.IsEmpty);
            Assert.AreEqual<int>(0, stack.Size);

            for (int i = 0; i < this.maxSize; i++)
            {
                stack.Push($"Element {i}");
                Assert.AreEqual<int>(i + 1, stack.Size);
                Assert.AreEqual<string>($"Element {i}", stack.Top);
                Assert.IsFalse(stack.IsEmpty);
            }

            for (int i = this.maxSize - 1; i >= 0; i--)
            {
                Assert.IsFalse(stack.IsEmpty);
                Assert.AreEqual<string>($"Element {i}", stack.Pop());
                Assert.AreEqual<int>(i, stack.Size);
            }

            Assert.IsTrue(stack.IsEmpty);
            Assert.AreEqual<int>(0, stack.Size);
        }
    }
}
