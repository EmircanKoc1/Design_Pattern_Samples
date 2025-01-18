namespace Structural.Composite.Sample1
{

    public class Entity : Object
    {
        public string Name { get; }

        public Entity(string name)
        {
            Name = name;
        }

        public override void ReviewInnerObjects()
        {
            Console.WriteLine($"This is a entity and id : {Id}");
        }
    }
}
