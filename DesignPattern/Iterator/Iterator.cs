using System;

namespace Iterator
{
    public interface ITerator
    {
        bool MoveNext();
        Object GetCurrent();
        void Next();
        void Reset();

    }
}