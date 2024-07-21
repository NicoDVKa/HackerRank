using FluentAssertions;
using HackerRank.A_Very_Big_Sum;

namespace Tests
{
    public class AVeryBigSumTests
    {

        [Test]
        public void EmptyList()
        {
            // Arrange
            var arr = new List<long>();

            // Act
            var result = AVeryBigSum.aVeryBigSum(arr);

            // Assert
            result.Should().Be(0);
        }

        [Test]
        [TestCase(1000000001)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(10000100001)]
        public void SingleElement(long element)
        {
            // Arrange
            var arr = new List<long>() { element };

            // Act
            var result = AVeryBigSum.aVeryBigSum(arr);

            // Assert
            result.Should().Be(element);
        }

        [Test]
        public void ManyElements()
        {
            // Arrange
            var arr = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            var expectedSum = 5000000015;

            // Act
            var result = AVeryBigSum.aVeryBigSum(arr);

            // Assert
            result.Should().Be(expectedSum);
        }
    }
}