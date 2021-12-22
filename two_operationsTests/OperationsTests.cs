using NUnit.Framework;
using System.Collections.Generic;
using two_operations;

namespace two_operations {
    [TestFixture]
    public class OperationsTests {

        [TestCase(1024, 10)]
        [TestCase(2, 1)]
        [TestCase(9, 4)]
        public void Oreration_getMinOperations_defaultValue(long testValue, int expectedValue) {
            Operations operations = new Operations();

            List<int> expected = new List<int> { expectedValue };
            List<int> result = operations.getMinOperations(new List<long> { testValue });

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Oreration_getMinOperations_ArgumentNullException() {
            Operations operations = new Operations();
            bool result = false;

            try {
                operations.getMinOperations(new List<long> { });
            } catch(System.ArgumentNullException) {
                result = true;
            }

            Assert.IsTrue(result);
        }
    }
}              