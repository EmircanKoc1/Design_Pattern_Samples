namespace Behavioral.Iterator.Sample1
{
    public class PersonIterator : IIterator
    {
        private readonly PersonAggregate _personAggregate;
        private int current = -1;
        public PersonIterator(PersonAggregate personAggregate)
            => _personAggregate = personAggregate;

        public object Current => _personAggregate[current];

        public bool MoveNext()
        {

            if (++current < _personAggregate.Count)
                return true;

            return false;
        }

        public void Reset()
            => current = -1;
    }


}
