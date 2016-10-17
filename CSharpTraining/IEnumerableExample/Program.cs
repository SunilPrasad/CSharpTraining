using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);

            var enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            foreach (var listItem in list)
            {
                Console.WriteLine(listItem);
            }
        }

        public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }
    }

    public class List : IEnumerable
    {
        private object[] _objects;
        private int _totalNumberOfElements;

        public List()
        {
            _objects = new object[100];
        }

        public void Add(object obj)
        {
            _objects[_totalNumberOfElements] = obj;
            _totalNumberOfElements++;
        }

        public IEnumerator GetEnumerator()
        {
            return new ListEnumerator(this);
        }

        public class ListEnumerator : IEnumerator
        {
            private List _list;
            private int _currentIndex = -1;

            public ListEnumerator(List list)
            {
                _list = list;
            }           

            public bool MoveNext()
            {
                _currentIndex++;

                return (_currentIndex < _list._totalNumberOfElements);
            }

            public object Current
            {
                get
                {
                    try
                    {
                        return _list._objects[_currentIndex];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            public void Reset()
            {
                _currentIndex = -1;
            }
        }
    }

    
}
