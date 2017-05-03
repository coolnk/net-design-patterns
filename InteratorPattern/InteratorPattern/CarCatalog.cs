using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteratorPattern
{
    class CarCatalog : IEnumerable<Car>
    {
        private List<Car> _cars;
        private int _max;
        private int _current;

        public CarCatalog( int max)
        {
            _max = max;
            _cars =  new List<Car>();
            _current = 0;
        }

        public void Add(Car car)
        {
            if(_current < _max)
            { 
                _cars.Add(car);
                _current++;
            }
        }        

        public IEnumerator<Car> GetEnumerator()
        {
            for(int i=0; i<_max; i++)
            {
                yield return _cars[i];
            }

            //return new CarEnumerator(_max, _cars);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
