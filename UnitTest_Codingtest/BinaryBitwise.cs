using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_Codingtest
{
    [TestClass]
    public class BinaryBitwise
    {
        [TestMethod]
        public void LeftShiftOperation()
        {
            byte b1 = 154;
            byte b2 = (byte)(b1 << 1);   

            Assert.AreEqual(b2, 52);
        }

        [TestMethod ]
        public void RightShiftOperation()
        {
        
            byte b = (byte)(64 >> 3);

            Assert.AreEqual(b, 8);
        }

        [TestMethod]
        public void XorSwap()
        {
            int x = 2846;
            int y = 23;
            x ^= y;
            y ^= x;
            x ^= y;

            Assert.AreEqual(x, 23);
            Assert.AreEqual(y, 2846);
        }
    }
}
