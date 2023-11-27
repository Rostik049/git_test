﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace git_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.AreEqual(10, product.amount);
            product = five.Times(3);
            Assert.AreEqual(15, product.amount);
        }
    }
}
