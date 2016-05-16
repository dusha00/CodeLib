namespace Iterator
{
    public class ConcreteIterator:ITerator
    {
        private ConcreteList _list;
        private int _index;

        public ConcreteIterator(ConcreteList list)
        {
            _list = list;
            _index = 0;
        }
        public bool MoveNext()
        {
            if (_index < _list.Length)
            {
                return true;
            }
            return false;
        }

        public object GetCurrent()
        {
            return _list.GetElement(_index);
        }

        public void Next()
        {
            if (_index < _list.Length)
            {
                _index++;
            }
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}