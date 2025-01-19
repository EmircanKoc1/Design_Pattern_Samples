namespace Behavioral.Iterator.Sample1
{
    public class PersonAggregate : IAggregate
    {
        //public PersonAggregate(int maxPersonCount)
        //    => _persons = new Person[maxPersonCount];

        public PersonAggregate(Person[] people)
        {
            _people = people ?? throw new ArgumentNullException();
        }

        private readonly Person[] _people;
        public int Count => _people.Length;
        public Person this[int index] => _people[index];

        public IIterator GetIterator()
            => new PersonIterator(this);


    }


}
