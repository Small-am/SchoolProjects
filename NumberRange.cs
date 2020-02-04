using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public struct NumberRange
    {
        private const int default_lowerbound = 0;
        private const int default_upperbound = 8;

        private int _lowerbound;
        private int _upperbound;

        public int LowerBound
        {
            get { return _lowerbound;  }
        }
        public int UpperBound
        {
            get { return _upperbound;  }
        }
        public NumberRange(int lowerbound, int upperbound)
        {
            if (lowerbound < upperbound)
            {
                _lowerbound = lowerbound;
                _upperbound = upperbound;
            }
            else
            {
                _lowerbound = default_lowerbound;
                _upperbound = default_upperbound;

            }
        }
    }
}
