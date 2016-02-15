using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SeriesXAPI
{
    public class SeriesX
    {
        private static readonly BigInteger DefaultElement = new BigInteger(1);
        private readonly Queue<BigInteger> _seriesX = new Queue<BigInteger> (new[] { DefaultElement, DefaultElement, DefaultElement } );
        private BigInteger _initialPosition = new BigInteger(1);

        public BigInteger GetElementValue(BigInteger divisor, BigInteger position)
        {
            if (divisor == DefaultElement)
            {
                if (position <= _seriesX.Count)
                {
                    return DefaultElement;
                }
                _initialPosition = new BigInteger(_seriesX.Count+1);
            }
            while (true)
            {
                var element = _seriesX.Aggregate(BigInteger.Add);
                if (element % divisor == 0)
                {
                    if (_initialPosition == position)
                    {
                        return element;
                    }
                    _initialPosition++;
                }
                _seriesX.Dequeue();
                _seriesX.Enqueue(element);
            }
        }
    }
}