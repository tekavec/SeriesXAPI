using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SeriesXAPI
{
    public class SeriesX
    {
        private readonly Queue<BigInteger> _seriesX = new Queue<BigInteger>(4);

        public SeriesX()
        {
            _seriesX.Enqueue(new BigInteger(1));
            _seriesX.Enqueue(new BigInteger(1));
            _seriesX.Enqueue(new BigInteger(1));
        }

        public BigInteger GetElementValue(BigInteger divisor, BigInteger position)
        {
            var initialPosition = new BigInteger(1);
            foreach (var element in _seriesX)
            {
                if (element%divisor == 0)
                {
                    if (initialPosition == position)
                    {
                        return element;
                    }
                    else
                    {
                        initialPosition ++;
                    }
                }
            }
            while (true)
            {
                var element = _seriesX.Aggregate(BigInteger.Add);
                if (element % divisor == 0)
                {
                    if (initialPosition == position)
                    {
                        return element;
                    }
                    else
                    {
                        initialPosition++;
                    }
                }
                _seriesX.Enqueue(element);
                _seriesX.Dequeue();
            }
        }
    }
}