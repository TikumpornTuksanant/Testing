﻿using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace UnitTest.TestFundamentals
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var math = new Math();
            var result = math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
    }

}
