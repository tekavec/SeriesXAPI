using System.Numerics;
using NUnit.Framework;

namespace SeriesXAPI.Tests
{
    [TestFixture]
    public class SeriesXShould
    {

        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 1)]
        [TestCase(1, 4, 3)]
        [TestCase(3, 1, 3)]
        [TestCase(3, 2, 9)]
        [TestCase(3, 3, 57)]
        [TestCase(5, 1, 5)]
        [TestCase(5, 2, 105)]
        public void return_nth_element_value_which_is_divisible_by_a_given_number_at_nth_position(
            int divisor, int position, int expected)
        {
            var seriesX = new SeriesX();
            var result = seriesX.GetElementValue(new BigInteger(divisor), new BigInteger(position));

            Assert.AreEqual(new BigInteger(expected), result);
        }

    }
}