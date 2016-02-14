using System.Numerics;
using NUnit.Framework;

namespace SeriesXAPI.Tests
{
    [TestFixture]
    public class SeriesXShould
    {

        [TestCase(3,1,3)]
        public void return_nth_element_value_which_is_divisible_by_a_given_number_at_nth_position(long divisor, long position, long value)
        {
            var seriesX = new SeriesX();
            var result = seriesX.GetElementValue(new BigInteger(divisor), new BigInteger(position));

            Assert.AreEqual(new BigInteger(value), result);
        }

    }
}