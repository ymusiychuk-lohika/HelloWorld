using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionIsCorrect()
        {
            int a = 2;
            int b = 5;

            HelloWorld.Shared.HelloWorld hw = new Shared.HelloWorld();

            Assert.IsTrue(hw.AddNumbers(a, b) == 7);
        }
    }
}
