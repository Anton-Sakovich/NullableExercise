using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullableExercise.Tests
{
    [TestClass]
    public class AmateurNullableTests
    {
        [TestMethod]
        public void InitializationTests()
        {
            AmateurNullable<int> a = null;

            Assert.IsFalse(a.HasValue);
            Assert.ThrowsException<InvalidOperationException>(() => a.Value);

            a = 1;

            Assert.IsTrue(a.HasValue);
            Assert.AreEqual(a.Value, 1);
        }

        [TestMethod]
        public void ExplicitConversion_BackToValue_Tests()
        {
            AmateurNullable<int> a = null;

            Assert.ThrowsException<InvalidOperationException>(() => { int b = (int)a; });

            a = 1;

            Assert.AreEqual((int)a, 1);
        }
    }
}
