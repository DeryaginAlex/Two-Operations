using NUnit.Framework;
using System.Collections.Generic;
using TwoOperations;

namespace TwoOperationsTests {
    [TestFixture]
    public class Operations—alculatorTests {

        private Operations—alculator operations;
        [SetUp]
        public void SetUp() {
            operations = new Operations—alculator();
        }

        [TestCase(1024, 10)]
        [TestCase(2, 1)]
        [TestCase(9, 4)]
        public void GetMinOperations_defaultValue_Test(long testValue, int expectedValue) {
            List<int> expected = new List<int> { expectedValue };
            List<int> result = operations.GetMinOperations(new List<long> { testValue });

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetMinOperations_ArgumentNullException_Test() {
            bool result = false;

            try {
                operations.GetMinOperations(new List<long> { });
            } catch(System.ArgumentNullException) {
                result = true;
            }

            Assert.IsTrue(result);
        }
    }
}     