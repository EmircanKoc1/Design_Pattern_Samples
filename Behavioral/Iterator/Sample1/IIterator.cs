namespace Behavioral.Iterator.Sample1
{
    public interface IIterator
    {
        void Reset();
        object Current { get; }
        bool MoveNext();
    }


}
