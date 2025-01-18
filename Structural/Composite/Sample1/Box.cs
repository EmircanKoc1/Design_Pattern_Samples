namespace Structural.Composite.Sample1
{
    public class Box : Object
    {
        IEnumerable<Object> InnerObjects;

        public Box(IEnumerable<Object> ınnerObjects)
        {
            InnerObjects = ınnerObjects;
        }

        public override void ReviewInnerObjects()
        {
            Console.WriteLine($"This is a box and id : {Id}");
            foreach (var innerObject in InnerObjects)
                innerObject.ReviewInnerObjects();
        }
    }
}
