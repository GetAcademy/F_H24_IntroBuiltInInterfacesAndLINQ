using System.Collections;

namespace IntroBuiltInInterfacesAndLINQ
{
    internal class DoublingNumberSequence : IEnumerable<int>, IEnumerator<int>
    {
        private int _maxNumber;

        // 1, 2, 4, 8, 16, 32, ...
        public int Current { get; private set; }

        public DoublingNumberSequence(int startNumber, int maxNumber)
        {
            _maxNumber = maxNumber;
            Current = startNumber;
        }


        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            if (Current >= _maxNumber) return false;
            Current *= 2;
            return true;
        }

        public void Reset()
        {
        }


        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
