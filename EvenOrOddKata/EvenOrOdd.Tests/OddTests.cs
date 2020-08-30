using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvenOrOdd.Tests
{
    public class OddTests
    {
        public EvenOrOdd _evenOrOdd;

        private const string ODD = "odd";

        [SetUp]
        public void SetUp()
        {
            _evenOrOdd = new EvenOrOdd();
        }

        [Test]
        public void EvenOrOdd_OneNumber_IsOdd()
        {
            string response = _evenOrOdd.IsEvenOrOdd(new int[1] { 1 });

            Assert.IsTrue(response.CompareStringOrdinalIgnoreCase(ODD));
        }

        [Test]
        public void EvenOrOdd_TwoNumbers_IsOdd()
        {
            string response = _evenOrOdd.IsEvenOrOdd(new int[2] { 3, 4 });

            Assert.IsTrue(response.CompareStringOrdinalIgnoreCase(ODD));
        }

        [Test]
        public void EvenOrOdd_EmptyArray_IsOdd_Fails()
        {
            string response = _evenOrOdd.IsEvenOrOdd(new int[0] { });

            Assert.IsFalse(response.CompareStringOrdinalIgnoreCase(ODD));
        }

        [Test]
        public void EvenOrOdd_TenNumbers_IsOdd()
        {
            string response = _evenOrOdd.IsEvenOrOdd(new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 2 });

            Assert.IsTrue(response.CompareStringOrdinalIgnoreCase(ODD));
        }

    }
}
