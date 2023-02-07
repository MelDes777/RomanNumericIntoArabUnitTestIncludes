using NUnit.Framework;
using RomanNumericIntoArabUnitTestIncludes;

namespace Business.Tests
{
    [TestFixture]
    public class RomanNumeralTests
    {
        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        public void RomanTransformation_FromString_ToNumeric(int expected, string roman)
        {
            Assert.That(expected, Is.EqualTo(RomanNumeral.Parse(roman)));

        }
    }
}