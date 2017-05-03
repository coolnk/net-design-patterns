using System;
using System.Collections;
using System.Collections.Generic;

namespace InteratorPattern
{
    internal class CarEnumerator : IEnumerator<Car>
    {
        private int _max;
        private int _index;
        private Car _current;
        List<Car> _cars;

        public CarEnumerator(int max, List<Car> cars)
        {
            _max = max;
            _cars = cars;
            _index = 0;
        }

        public Car Current
        {
            get
            {               
                return _current;                 
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
      
            if (_index != _max)
            {
                _current = _cars[_index];
                _index++;
                return true;

            }
            return false;

        }

        public void Reset()
        {
            _index = 0;
        }
    }
}