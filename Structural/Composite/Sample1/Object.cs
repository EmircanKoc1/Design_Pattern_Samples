namespace Structural.Composite.Sample1
{
    public abstract class Object
    {
        protected Guid Id { get; } = Guid.NewGuid();
        public abstract void ReviewInnerObjects();

    }
}
