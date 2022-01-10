using FluentAssertions;
using NUnit.Framework;

namespace UnitTest
{
    public class Tests
    {
        private CountingDuplicates.CountingDuplicates _countingDuplicates;
        [SetUp]
        public void Setup()
        {
            _countingDuplicates = new CountingDuplicates.CountingDuplicates();
        }

        [Test]
        [TestCase(null, 0)]
        [TestCase("", 0)]
        [TestCase("abcde", 0)]
        [TestCase("aabbcde", 2)]
        [TestCase("aabBcde", 2)]
        [TestCase("Indivisibility", 1, TestName = "should ignore case")]
        [TestCase("Indivisibilities", 2, TestName = "characters may not be adjacent")]
        [TestCase("aA11", 2)]
        public void Can_get_duplicate_count(string input, int expect)
        {
            var result = _countingDuplicates.Count(input);
            result.Should().Be(expect);
        }
    }
}