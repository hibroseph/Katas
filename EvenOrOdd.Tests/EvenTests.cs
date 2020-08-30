using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace EvenOrOdd.Tests
{
    public class EvenTests
    {
        public EvenOrOdd _evenOrOdd;

        private const string EVEN = "even";
        private const string ODD = "odd";

        [SetUp]
        public void Setup()
        {
            _evenOrOdd = new EvenOrOdd();
        }

        [Test]
        public void EvenOrOdd_FiveNumbers_IsEven()
        {
            string response = _evenOrOdd.IsEvenOrOdd(new int[5] { 1, 2, 3, 4, 6 });

            Assert.IsTrue(response.CompareStringOrdinalIgnoreCase(EVEN));
        }

        [Test]
        public void EvenOrOdd_EmptyArray_IsEven()
        {
            string response = _evenOrOdd.IsEvenOrOdd(new int[0] { });

            Assert.IsTrue(response.CompareStringOrdinalIgnoreCase(EVEN));
        }

        [Test]
        public void EvenOrOdd_NullArray_ThrowsNullArgumentException()
        {
            Assert.Throws<ArgumentNullException>(() => _evenOrOdd.IsEvenOrOdd(null));
        }

        [Test]
        public void EvenOrOdd_TenNumbers_IsEven()
        {
            string response = _evenOrOdd.IsEvenOrOdd(new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });

            Assert.IsTrue(response.CompareStringOrdinalIgnoreCase(EVEN));
        }

        [Test]
        public void EvenOrOdd_OneNumber_IsEven()
        {
            string response = _evenOrOdd.IsEvenOrOdd(new int[1] { 2 });

            Assert.IsTrue(response.CompareStringOrdinalIgnoreCase(EVEN));
        }
    }
}