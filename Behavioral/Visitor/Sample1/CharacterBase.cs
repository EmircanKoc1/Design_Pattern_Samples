namespace Behavioral.Visitor.Sample1;

public abstract class CharacterBase : ICharacter
{
    public abstract double Health { get; set; }
    public abstract double MaxHealth { get; }
    public abstract double ImprovementFactor { get; set; }
    public abstract int Durability { get; set; }

    public void AcceptVisitor(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public override string ToString()
    {
        return $"""
            Character Type : {GetType().Name} 
            Health : {Health}
            ImprovementFactor : {ImprovementFactor}
            Durability : {Durability}
            """;
    }
}

